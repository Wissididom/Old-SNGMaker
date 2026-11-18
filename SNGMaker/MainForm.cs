using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SNGMaker
{
    public partial class MainForm : Form
    {
        public string DescriptionFile = Path.Combine(Application.StartupPath, "sngDesc.xml");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tc.SelectedIndex > 0 && Tc.SelectedTab != Tp4)
            {
                var fctb = GetActiveFastColoredTextBox();
                UndoToolStripButton.Enabled = fctb.UndoEnabled;
                RedoToolStripButton.Enabled = fctb.RedoEnabled;
                Ts.Visible = true;
            }
            else
            {
                Ts.Visible = false;
            }
            if (Tc.SelectedIndex == 2)
            {
                var ccli = 0;
                if (PropertiesControl1.GetByProperty("CCLI-Nummer").Value != string.Empty)
                {
                    if (!int.TryParse(PropertiesControl1.GetByProperty("CCLI-Nummer").Value, out ccli))
                    {
                        ccli = 0;
                    }
                }
                var churchsongid = 0;
                if (PropertiesControl1.GetByProperty("interne ID").Value != string.Empty)
                {
                    if (!int.TryParse(PropertiesControl1.GetByProperty("interne ID").Value, out churchsongid))
                    {
                        churchsongid = 0;
                    }
                }
                var langcount = 0;
                if (PropertiesControl1.GetByProperty("Übersetzungsanzahl").Value != string.Empty)
                {
                    if (!int.TryParse(PropertiesControl1.GetByProperty("Übersetzungsanzahl").Value, out langcount))
                    {
                        langcount = 0;
                    }
                }
                var tempo = 0;
                if (PropertiesControl1.GetByProperty("Tempo").Value != string.Empty)
                {
                    if (!int.TryParse(PropertiesControl1.GetByProperty("Tempo").Value, out tempo))
                    {
                        langcount = 0;
                    }
                }
                var fontsize = 0;
                if (PropertiesControl1.GetByProperty("Schriftgröße").Value != string.Empty)
                {
                    if (!int.TryParse(PropertiesControl1.GetByProperty("Schriftgröße").Value, out fontsize))
                    {
                        fontsize = 0;
                    }
                }
                FctbFinishedSngFile.Text = SngHandler.GenerateCompleteSngFile(
                    PropertiesControl1.GetByProperty("Titel").Value,
                    PropertiesControl1.GetByProperty("Autor").Value,
                    PropertiesControl1.GetByProperty("Melodie").Value,
                    PropertiesControl1.GetByProperty("Übersetzung").Value,
                    PropertiesControl1.GetByProperty("©").Value,
                    PropertiesControl1.GetByProperty("National-©").Value,
                    PropertiesControl1.GetByProperty("Zusatz-Rechte").Value,
                    PropertiesControl1.GetByProperty("Zusatz-©").Value,
                    ccli,
                    PropertiesControl1.GetByProperty("Editor").Value,
                    PropertiesControl1.GetByProperty("Bibel").Value,
                    PropertiesControl1.GetByProperty("Kategorieen").Value,
                    PropertiesControl1.GetByProperty("Stichworte").Value,
                    PropertiesControl1.GetByProperty("Schnellsuche").Value,
                    churchsongid,
                    PropertiesControl1.GetByProperty("Kommentar").Value,
                    Convert.ToBase64String(Encoding.Default.GetBytes(PropertiesControl1.GetByProperty("Kommentare").Value)),
                    PropertiesControl1.GetByProperty("Schlüssel").Value,
                    PropertiesControl1.GetByProperty("Reihenfolge").Value,
                    PropertiesControl1.GetByProperty("Songbuch").Value,
                    langcount,
                    PropertiesControl1.GetByProperty("Sprache").Value,
                    tempo,
                    PropertiesControl1.GetByProperty("Titel - Sprache-N").Value.Split('|'),
                    PropertiesControl1.GetByProperty("Originaltitel").Value,
                    PropertiesControl1.GetByProperty("Hintergrundbild").Value,
                    PropertiesControl1.GetByProperty("Schrift").Value,
                    PropertiesControl1.GetByProperty("Schrift - Sprache-N").Value.Split('|'),
                    fontsize,
                    PropertiesControl1.GetByProperty("Textausrichtung").Value,
                    PropertiesControl1.GetByProperty("Titelausrichtung").Value,
                    FctbSlides.Text);
            }
            if (Tc.SelectedTab == Tp4)
            {
                Tc.SelectedIndex = 0;
                MessageBox.Show("Achtung, diese Funktion ist noch fehlerhaft.", "Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var ofd = new OpenFileDialog
                {
                    Title = "öffnen...",
                    Multiselect = false,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    FileName = "nichts gewählt",
                    Filter = "SNG-Dateien|*.sng|Textdokumente|*.txt|Alle Dateien|*.*"
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var dic = SngHandler.Parse(ofd.FileName, false);
                    foreach (PropertiesControlEntry p in PropertiesControl1.Controls)
                    {
                        try
                        {
                            p.Value = dic[SngHandler.GetEnglishWord(p.Property).ToLower()];
                        }
                        catch (Exception)
                        {
                            // do nothing
                        }
                    }
                    FctbSlides.Text = dic["slides"];
                    TextChangedDelayed(FctbSlides, new FastColoredTextBoxNS.TextChangedEventArgs(FctbSlides.Range));
                }
            }
        }

        public FastColoredTextBoxNS.FastColoredTextBox GetActiveFastColoredTextBox()
        {
            if (Tc.SelectedTab == Tp2)
            {
                return FctbSlides;
            }
            else if (Tc.SelectedTab == Tp3)
            {
                return FctbFinishedSngFile;
            }
            else
            {
                throw new ArgumentException("Der aktuelle Tab hat keine FastColoredTextBox.");
            }
        }

        private void CutToolStripButton_Click(object? sender, EventArgs e)
        {
            GetActiveFastColoredTextBox().Cut();
        }

        private void CopyToolStripButton_Click(object? sender, EventArgs e)
        {
            GetActiveFastColoredTextBox().Copy();
        }

        private void PasteToolStripButton_Click(object? sender, EventArgs e)
        {
            GetActiveFastColoredTextBox().Paste();
        }

        private void UndoToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            UndoToolStripButton.Enabled = fctb.UndoEnabled;
            if (fctb.UndoEnabled)
            {
                fctb.Undo();
            }
        }

        private void RedoToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            RedoToolStripButton.Enabled = fctb.RedoEnabled;
            if (fctb.RedoEnabled)
            {
                fctb.Redo();
            }
        }

        private void BoldToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            fctb.SelectedText = $"<b>{fctb.SelectedText}</b>";
        }

        private void ItalicsToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            fctb.SelectedText = $"<i>{fctb.SelectedText}</i>";
        }

        private void UnderlineToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            fctb.SelectedText = $"<u>{fctb.SelectedText}</u>";
        }

        private void StrikeOutToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            fctb.SelectedText = $"<strike>{fctb.SelectedText}</strike>";
        }

        private void AlignToolStripButton_Click(object? sender, EventArgs e)
        {
            var aib = new AlignInputBox();
            if (aib.ShowDialog() == DialogResult.OK)
            {
                GetActiveFastColoredTextBox().InsertLinePrefix($"<align:{aib.Value}>");
            }
        }

        private void VAlignToolStripButton_Click(object? sender, EventArgs e)
        {
            var vaib = new VAlignInputBox();
            if (vaib.ShowDialog() == DialogResult.OK)
            {
                GetActiveFastColoredTextBox().InsertLinePrefix($"<valign:{vaib.Value}>");
            }
        }

        private void ColoredTextToolStripButton_Click(object? sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                var fctb = GetActiveFastColoredTextBox();
                fctb.SelectedText = $"<c:${cd.Color.ToArgb().ToString("x")[2..]}>{fctb.SelectedText}</c>";
            }
        }

        private void WordWrapToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            fctb.SelectedText = $"<wordwrap>{fctb.SelectedText}</wordwrap>";
        }

        private void SubscriptToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            fctb.SelectedText = $"<sub>{fctb.SelectedText}</sub>";
        }

        private void SuperscriptToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            fctb.SelectedText = $"<super>{fctb.SelectedText}</super>";
        }

        private void LinespacingToolStripButton_Click(object? sender, EventArgs e)
        {
            var nib = new NumberInputBox();
            if (nib.ShowDialog() == DialogResult.OK)
            {
                GetActiveFastColoredTextBox().InsertLinePrefix($"<linespacing:{Strings.FormatNumber(nib.Value, 1, TriState.False, TriState.False, TriState.False).Replace(",", ".")}>");
            }
        }

        private void FontToolStripButton_Click(object? sender, EventArgs e)
        {
            var fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var fctb = GetActiveFastColoredTextBox();
                var size = fd.Values.Split(';')[0].Split(':')[1];
                var height = fd.Values.Split(';')[1].Split(':')[1];
                var tempString = fctb.SelectedText;
                if (fd.HasSize) tempString = $"<s:{size}>{tempString}</s>";
                if (fd.HasHeight) tempString = $"<h:{height}>{tempString}</h>";
                fctb.SelectedText = tempString;
            }
        }

        private void ZeilenZwischenDieOberenZeilenToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            var separated = fctb.Text.Split(["---"], StringSplitOptions.None);
            var aboveLine = separated[0].TrimEnd().Split(["\r\n"], StringSplitOptions.None);
            var underLine = separated[1].TrimStart().Split(["\r\n"], StringSplitOptions.None);
            var useAbove = true;
            if (separated.Length > 2)
            {
                for (var i = 2; i < separated.Length; i++)
                {
                    if (useAbove)
                    {
                        var tempList = aboveLine.ToList();
                        tempList.AddRange(separated[i].TrimEnd().Split(["\r\n"], StringSplitOptions.None));
                        aboveLine = [.. tempList];
                    }
                    else
                    {
                        var tempList = underLine.ToList();
                        tempList.AddRange(separated[i].TrimStart().Split(["\r\n"], StringSplitOptions.None));
                        underLine = [.. tempList];
                    }
                    useAbove = !useAbove;
                }
            }
            var newString = new StringBuilder();
            for (var i = 0; i < aboveLine.Length; i++)
            {
                if (i == aboveLine.Length - 1)
                {
                    newString.Append($"{aboveLine[i]}\r\n{underLine[i]}");
                }
                else
                {
                    newString.Append($"{aboveLine[i]}\r\n{underLine[i]}\r\n");
                }
            }
            fctb.Text = newString.ToString();
            fctb.Text = fctb.Text.Replace("\r\n\r\n", "\r\n---");
        }

        private void NewLineToolStripButton_Click(object? sender, EventArgs e)
        {
            GetActiveFastColoredTextBox().InsertText("<br>");
        }

        private void NewParagraphToolStripButton_Click(object? sender, EventArgs e)
        {
            GetActiveFastColoredTextBox().InsertText("<p>");
        }

        private void SprachenAufZweiFolienAufteilenToolStripButton_Click(object? sender, EventArgs e)
        {
            var fctb = GetActiveFastColoredTextBox();
            var separated = fctb.Text.Split(["\r\n"], StringSplitOptions.None);
            var aboveList = new List<string>();
            var underList = new List<string>();
            for (var i = 0; i < separated.Length; i++)
            {
                if (i % 2 == 0) // Is Even
                {
                    aboveList.Add(separated[i]);
                }
                else
                {
                    underList.Add(separated[i]);
                }
            }
            var aboveLine = aboveList.ToArray();
            var underLine = underList.ToArray();
            var newString = new StringBuilder();
            for (var i = 0; i < aboveLine.Length; i++)
            {
                if (i == aboveLine.Length - 1)
                {
                    newString.Append($"{aboveLine[i]}\r\n");
                }
                else
                {
                    newString.Append($"{aboveLine[i]}\r\n---\r\n");
                }
            }
            for (var i = 0; i < underLine.Length; i++)
            {
                if (i == underLine.Length - 1)
                {
                    newString.Append(underLine[i]);
                }
                else
                {
                    newString.Append($"{underLine[i]}\r\n");
                }
            }
            fctb.Text = newString.ToString();
        }

        private void TextChangedDelayed(object? sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            try
            {
                var senderFctb = (FastColoredTextBoxNS.FastColoredTextBox?)sender;
                if (File.Exists(DescriptionFile))
                {
                    senderFctb?.DescriptionFile = DescriptionFile;
                    senderFctb?.SyntaxHighlighter.HighlightSyntax(FastColoredTextBoxNS.Language.Custom, senderFctb.Range);
                }
                if (string.IsNullOrEmpty(FctbSlides.Text))
                {
                    if (Tc.TabPages.Contains(Tp3))
                    {
                        Tc.TabPages.Remove(Tp3);
                    }
                }
                else
                {
                    if (!Tc.TabPages.Contains(Tp3))
                    {
                        Tc.TabPages.Add(Tp3);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler aufgetreten.\r\n\r\nDie Beschreibung des SyntaxHighlighters ist fehlerhaft oder wurde nicht gefunden.", "Fehler aufgetreten");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DescriptionFile))
            {
                if (MessageBox.Show("Die Beschreibung des SyntaxHighlighters wurde nicht gefunden.\r\nWollen Sie die Datei selbst suchen?", "Beschreibung nicht gefunden", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using var ofd = new OpenFileDialog();
                    ofd.Title = "Beschreibung suchen";
                    ofd.InitialDirectory = Application.StartupPath;
                    ofd.FileName = "sngDesc.xml";
                    ofd.Filter = "XML-Datei|*.xml|XML-Datei als *.txt|*.txt|XML-Datei mit anderer Dateierweiterung|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        DescriptionFile = ofd.FileName;
                    }
                }
            }
            Tc.TabPages.Remove(Tp3);
            string[] properties =
            [
                "Titel", "Autor", "Melodie", "Übersetzung", "©", "National-©",
                "Zusatz-Rechte", "Zusatz-©", "CCLI-Nummer", "Editor",
                "Bibel", "Kategorieen", "Stichworte", "Schnellsuche", "interne ID",
                "Kommentar", "Kommentare", "Schlüssel", "Reihenfolge", "Songbuch",
                "Übersetzungsanzahl", "Sprache", "Tempo", "Titel - Sprache-N",
                "Originaltitel", "Hintergrundbild", "Schrift", "Schrift - Sprache-N",
                "Schriftgröße", "Textausrichtung", "Titelausrichtung"
            ];
            var tIndex = properties.Length - 1;
            foreach (var property in properties.Reverse())
            {
                PropertiesControl1.InsertItem(GetPropertiesControlEntry(property, tIndex));
                tIndex--;
            }
        }

        private static PropertiesControlEntry GetPropertiesControlEntry(string property, int tIndex)
        {
            bool isNumeric = property == "CCLI-Nummer" ||
                            property == "interne ID" ||
                            property == "Übersetzungsanzahl" ||
                            property == "Tempo" ||
                            property == "Schriftgröße";
            return new PropertiesControlEntry(property, isNumeric)
            {
                TabIndex = tIndex
            };
        }

        private void BtnClearAll_Click(object? sender, EventArgs e)
        {
            foreach (PropertiesControlEntry property in PropertiesControl1.Controls)
            {
                property.Value = string.Empty;
            }
            FctbSlides.Clear();
            FctbFinishedSngFile.Clear();
        }

        private void BtnCopy_Click(object? sender, EventArgs e)
        {
            var selection = FctbFinishedSngFile.Selection;
            FctbFinishedSngFile.SelectAll();
            FctbFinishedSngFile.Copy();
            FctbFinishedSngFile.Selection = selection;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Title = "speichern...",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = PropertiesControl1.GetByProperty("Titel").Value.Replace(" ", "_")
            };
            var lst = new List<char>();
            lst.AddRange(Path.GetInvalidFileNameChars());
            lst.AddRange(Path.GetInvalidPathChars());
            foreach (var invalidChar in lst)
            {
                sfd.FileName = sfd.FileName.Replace(invalidChar, '_');
            }
            sfd.Filter = "SNG-Dateien|*.sng|Textdokumente|*.txt|Alle Dateien|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // FctbFinishedSngFile.SaveToFile(.FileName, System.Text.Encoding.Default)
                File.WriteAllText(sfd.FileName, FctbFinishedSngFile.Text, Encoding.UTF8);
            }
        }
    }
}

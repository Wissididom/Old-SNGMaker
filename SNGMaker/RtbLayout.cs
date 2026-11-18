using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace SNGMaker
{
    public class RtbLayout
    {
        public static void TextChanged(RichTextBox rtb)
        {
            var pos = rtb.SelectionStart;
            var cat1 = "([Pp][Rr][Ee]-([Bb][Rr][Ii][Dd][Gg][Ee]|[Rr][Ee][Ff][Rr][Aa][Ii][Nn]|[Cc][Hh][Oo][Rr][Uu][Ss]|[Cc][Oo][Dd][Aa]))";
            var cat2 = "([Uu][Nn][Bb][Ee]([Kk]|[Nn])[Aa][Nn][Nn][Tt]|[Uu][Nn][Kk][Nn][Oo][Ww][Nn])";
            var cat3 = "([Ii][Nn][Tt][Rr][Oo]|[Cc][Oo][Dd][Aa]|[Ee][Nn][Dd][Ii][Nn][Gg])";
            var cat4 = "([Vv][Ee][Rr][Ss][Ee]?|[Ss][Tt][Rr][Oo][Pp][Hh][Ee]|[Tt][Ee][Ii][Ll]|[Pp][Aa][Rr][Tt])";
            var cat5 = "([Bb][Rr][Ii][Dd][Gg][Ee]|[Mm][Ii][Ss][Cc]|[Zz][Ww][Ii][Ss][Cc][Hh][Ee][Nn][Ss][Pp][Ii][Ee][Ll]|[Ii][Nn][Tt][Ee][Rr][Ll][Uu][Dd][Ee])";
            var cat6 = "([Rr][Ee][Ff][Rr][Aa][Ii][Nn]|[Cc][Hh][Oo][Rr][Uu][Ss])";
            var cat7 = "([Cc][Hh][Oo][Rr])";
            rtb.SelectAll();
            rtb.SelectionBackColor = Color.White;
            rtb.SelectionColor = Color.Black;
            MarkWord(rtb, cat1, Color.FromArgb(170, 85, 255));
            MarkWord(rtb, cat2, Color.FromArgb(98, 176, 255));
            MarkWord(rtb, cat3, Color.FromArgb(0, 128, 64));
            MarkWord(rtb, cat4, Color.FromArgb(0, 128, 255));
            MarkWord(rtb, cat5, Color.FromArgb(204, 0, 0));
            MarkWord(rtb, cat6, Color.FromArgb(128, 0, 255));
            MarkWord(rtb, cat7, Color.FromArgb(170, 176, 255));
            MarkLine(rtb, Color.FromArgb(255, 0, 0));
            rtb.SelectionStart = pos;
            rtb.SelectionLength = 0;
        }

        public static void MarkWord(RichTextBox rtb, string word, Color bColor)
        {
            Mark(rtb, $"^({word}|{word} \\d*|{word} [A-Z])$", bColor, Color.White); // Vorlage: Mark(rtb, $"^({word}|{word} \\d*)$", bColor, Color.White)
        }

        public static void MarkLine(RichTextBox rtb, Color fColor)
        {
            Mark(rtb, "^---$", Color.White, fColor);
        }

        public static void Mark(RichTextBox rtb, string pattern, Color bColor, Color fColor)
        {
            var rOptions = RegexOptions.Multiline;
            var regex = new Regex(pattern, rOptions);
            foreach (Match m in regex.Matches(rtb.Text))
            {
                rtb.SelectionStart = m.Index;
                rtb.SelectionLength = m.Length;
                rtb.SelectionColor = fColor;
                rtb.SelectionBackColor = bColor;
            }
        }

        public static void ChangeFormatOfSong(SongFormatChanger type, RichTextBox rtb)
        {
            switch (type)
            {
                case SongFormatChanger.Align:
                    {
                        var fciocl = rtb.GetFirstCharIndexOfCurrentLine();
                        var str = Interaction.InputBox("Geben Sie die horizontale Ausrichtung ein (l|left|e|c|center|r|right|k|keep):", "Eingabe erforderlich");
                        if (!string.IsNullOrWhiteSpace(str))
                        {
                            str = str.Trim();
                            if (str == "l" || str == "left" || str == "e" || str == "c" || str == "center" || str == "r" || str == "right" || str == "k" || str == "keep")
                            {
                                // rtbFolien.Text.Insert(fciocl, $"<align:{str}>")
                                var left = Strings.Left(rtb.Text, fciocl);
                                var right = Strings.Right(rtb.Text, rtb.Text.Length - left.Length);
                                rtb.Text = $"{left}<align:{str}>{right}";
                            }
                        }
                        break;
                    }
                case SongFormatChanger.VAlign:
                    {
                        var fciocl = rtb.GetFirstCharIndexOfCurrentLine();
                        var str = Interaction.InputBox("Geben Sie die vertikale Ausrichtung ein (t|top|m|middle|b|bottom):", "Eingabe erforderlich");
                        if (!string.IsNullOrWhiteSpace(str))
                        {
                            str = str.Trim();
                            if (str == "t" || str == "top" || str == "m" || str == "middle" || str == "b" || str == "bottom")
                            {
                                var left = Strings.Left(rtb.Text, fciocl);
                                var right = Strings.Right(rtb.Text, rtb.Text.Length - left.Length);
                                rtb.Text = $"{left}<valign:{str}>{right}";
                            }
                        }
                        break;
                    }
                case SongFormatChanger.Bold:
                    {
                        rtb.SelectedText = $"<b>{rtb.SelectedText}</b>";
                        break;
                    }
                case SongFormatChanger.Italic:
                    {
                        rtb.SelectedText = $"<i>{rtb.SelectedText}</i>";
                        break;
                    }
                case SongFormatChanger.Underline:
                    {
                        rtb.SelectedText = $"<u>{rtb.SelectedText}</u>";
                        break;
                    }
                case SongFormatChanger.ColoredText:
                    {
                        var cd = new ColorDialog();
                        if (cd.ShowDialog() == DialogResult.OK)
                        {
                            // MessageBox.Show(cd.Color.ToArgb().ToString("X")[2..]);
                            // lesen: System.Drawing.ColorTranslator.FromHtml($"#{cd.Color.ToArgb().ToString("X")[2..]}");
                            rtb.SelectedText = $"<c:${cd.Color.ToArgb().ToString("X")[2..]}>{rtb.SelectedText}</c>";
                        }
                        break;
                    }
                case SongFormatChanger.Font:
                    {
                        var tempSize = -1;
                        var tempHeight = -1;
                        var tempSelectedText = rtb.SelectedText;
                        var fontDialog = new FontDialog();
                        if (fontDialog.ShowDialog() == DialogResult.OK)
                        {
                            if (!string.IsNullOrWhiteSpace(fontDialog.Values))
                            {
                                if (fontDialog.HasSize)
                                {
                                    tempSize = int.Parse(fontDialog.Values[5..fontDialog.Values.IndexOf(';')]);
                                }
                                if (fontDialog.HasHeight)
                                {
                                    tempHeight = int.Parse(fontDialog.Values[(fontDialog.Values.IndexOf(';') + 8)..]);
                                }
                            }
                        }
                        if (tempSize > -1)
                        {
                            tempSelectedText = $"<s:{tempSize}>{tempSelectedText}</s>";
                            // HasSize = true
                        }
                        if (tempHeight > -1)
                        {
                            tempSelectedText = $"<h:{tempHeight}>{tempSelectedText}</h>";
                            // HasHeight = true
                        }
                        rtb.SelectedText = tempSelectedText;
                        break;
                    }
                case SongFormatChanger.WordWrap:
                    {
                        rtb.SelectedText = $"<wordwrap>{rtb.SelectedText}</wordwrap>";
                        break;
                    }
                case SongFormatChanger.NewLine:
                    {
                        var left = Strings.Left(rtb.Text, rtb.SelectionStart);
                        var right = Strings.Right(rtb.Text, rtb.Text.Length - (rtb.SelectionStart + rtb.SelectionLength));
                        rtb.Text = $"{left}<br>{right}";
                        break;
                    }
                case SongFormatChanger.NewParagraph:
                    {
                        var left = Strings.Left(rtb.Text, rtb.SelectionStart);
                        var right = Strings.Right(rtb.Text, rtb.Text.Length - (rtb.SelectionStart + rtb.SelectionLength));
                        rtb.Text = $"{left}<p>{right}";
                        break;
                    }
                case SongFormatChanger.StrikeOut:
                    {
                        rtb.SelectedText = $"<strike>{rtb.SelectedText}</strike>";
                        break;
                    }
                case SongFormatChanger.Subscript:
                    {
                        rtb.SelectedText = $"<sub>{rtb.SelectedText}</sub>";
                        break;
                    }
                case SongFormatChanger.Superscript:
                    {
                        rtb.SelectedText = $"<super>{rtb.SelectedText}</super>";
                        break;
                    }
                case SongFormatChanger.Linespacing:
                    {
                        var fciocl = rtb.GetFirstCharIndexOfCurrentLine();
                        var str = Interaction.InputBox("Geben Sie den Zeilenabstand ein:", "Eingabe erforderlich", "1.0");
                        if (!string.IsNullOrWhiteSpace(str))
                        {
                            if (CheckInputMask(str, "#.#"))
                            {
                                var left = Strings.Left(rtb.Text, fciocl);
                                var right = Strings.Right(rtb.Text, rtb.Text.Length - left.Length);
                                rtb.Text = $"{left}<linespacing:{str}>{right}";
                            }
                            else if (CheckInputMask(str, "#"))
                            {
                                var left = Strings.Left(rtb.Text, fciocl);
                                var right = Strings.Right(rtb.Text, rtb.Text.Length - left.Length);
                                rtb.Text = $"{left}<linespacing:{str}.0>{right}";
                            }
                            else
                            {
                                MessageBox.Show("Sie haben ein falsches Format angegeben. Bitte nur Zahl - Punkt - Zahl", "Falsches Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    }
                case SongFormatChanger.MoveLinesBetween:
                    {
                        var separated = rtb.Text.Split(["---"], StringSplitOptions.None);
                        var aboveLine = separated[0].TrimEnd().Split('\n');
                        var underLine = separated[1].TrimStart().Split('\n');
                        var useAbove = true;
                        if (separated.Length > 2)
                        {
                            for (var i = 2; i < separated.Length; i++)
                            {
                                if (useAbove)
                                {
                                    var tempList = aboveLine.ToList();
                                    tempList.AddRange(separated[i].TrimEnd().Split('\n'));
                                    aboveLine = [.. tempList];
                                }
                                else
                                {
                                    var tempList = underLine.ToList();
                                    tempList.AddRange(separated[i].TrimStart().Split('\n'));
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
                        rtb.Text = newString.ToString();
                        rtb.Text = rtb.Text.Replace("\n\n", "\n---");
                        break;
                    }
                case SongFormatChanger.MoveLinesOnTwoFoils:
                    {
                        var separated = rtb.Text.Split(['\n'], StringSplitOptions.None);
                        var aboveList = new List<string>();
                        var underList = new List<string>();
                        for (var i = 0; i < separated.Length; i++)
                        {
                            if (i % 2 == 0) // Is even
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
                                newString.Append($"{aboveLine[i]}\r\n---\r\n");
                            }
                            else
                            {
                                newString.Append($"{aboveLine[i]}\r\n");
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
                        rtb.Text = newString.ToString();
                        break;
                    }
            }
        }

        /// <summary>
        /// Prüft ob ein String ein bestimmtes Format aufweist
        /// </summary>
        /// <param name="sInput">Der String, der das Format aufweisen soll</param>
        /// <param name="sMask">Der String der das Format angibt (# = numerisches Zeichen, &amp; = alphanumerisches Zeichen)</param>
        /// <returns></returns>
        public static bool CheckInputMask(string input, string mask)
        {
            if (input.Length != mask.Length)
            {
                return false;
            }
            for (var i = 0; i < mask.Length; i++)
            {
                var c = mask[i];
                switch (c)
                {
                    case '#':
                        if (!char.IsDigit(input[i]))
                        {
                            return false;
                        }
                        break;
                    case '&':
                        if (!char.IsLetterOrDigit(input[i]))
                        {
                            return false;
                        }
                        break;
                    default:
                        if (input[i] != c)
                        {
                            return false;
                        }
                        break;
                }
            }
            return true;
        }
    }
}

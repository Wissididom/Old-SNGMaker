using System.Text;

namespace SNGMaker
{
    public class SngHandler
    {
        /// <summary>
        /// A SNG file starts with the properties of the song. This Function generates the properties-part of the SNG file and appends three hyphens at the end of it. The properties-part of the SNG file will be returned.
        /// </summary>
        /// <param name="title">song title</param>
        /// <param name="author">name of the lyrics author</param>
        /// <param name="melody">name of componist</param>
        /// <param name="translation">name of translation author</param>
        /// <param name="c">copyright information</param>
        /// <param name="natcopyright">national copyright information</param>
        /// <param name="rights">additional rights (e.g. for translated lyrics)</param>
        /// <param name="addcopyrightinfo">additional copyright information</param>
        /// <param name="ccli">CCLI number</param>
        /// <param name="editor">name of editing program</param>
        /// <param name="bible">bible passage the text is based on</param>
        /// <param name="categories">categories the song is about</param>
        /// <param name="keywords">search keywords</param>
        /// <param name="quickfind">quick find string like STTN for "Shout to the North"</param>
        /// <param name="churchsongid">internal ID</param>
        /// <param name="comment">arbitrary comment</param>
        /// <param name="comments">Comment encoded with base64</param>
        /// <param name="key">mus. key of the song</param>
        /// <param name="verseorder">order of the song parts</param>
        /// <param name="songbook">also written: SongBook</param>
        /// <param name="langcount">number of translations in song file</param>
        /// <param name="lang">language of the song</param>
        /// <param name="tempo">tempo of the song</param>
        /// <param name="titlelang">song title in other language</param>
        /// <param name="otitle">original title</param>
        /// <param name="backgroundimage">Path to background relative to image folder. Observed file types: JPEG, PNG, BMP, WMV, AVI</param>
        /// <param name="font">font for lyrics</param>
        /// <param name="fontlang">font for other lyrics</param>
        /// <param name="fontsize">font size for lyrics</param>
        /// <param name="textalign">text alignment</param>
        /// <param name="titlealign">title alignment</param>
        /// <remarks>Quelle: http://wiki.openlp.org/Development:SongBeamer_-_Song_Data_Format#Properties</remarks>
        public static string GenerateProperties(string? title, string? author, string? melody,
                        string? translation, string? c, string? natcopyright, string? rights,
                        string? addcopyrightinfo, int ccli,
                        string? editor, string? bible, string? categories,
                        string? keywords, string? quickfind, int churchsongid,
                        string? comment, string? comments, string? key, string? verseorder,
                        string? songbook, int langcount, string? lang, int tempo,
                        string[]? titlelang, string? otitle, string? backgroundimage,
                        string? font, string[]? fontlang, int fontsize, string? textalign,
                        string? titlealign)
        {
            var settings = string.Empty;
            if (!string.IsNullOrEmpty(title)) settings += $"#Title={title}\r\n";
            if (!string.IsNullOrEmpty(author)) settings += $"#Author={author}\r\n";
            if (!string.IsNullOrEmpty(melody)) settings += $"#Melody={melody}\r\n";
            if (!string.IsNullOrEmpty(translation)) settings += $"#Translation={translation}\r\n";
            if (!string.IsNullOrEmpty(c)) settings += $"#(c)={c}\r\n";
            if (!string.IsNullOrEmpty(natcopyright)) settings += $"#NatCopyright={natcopyright}\r\n";
            if (!string.IsNullOrEmpty(rights)) settings += $"#Rights={rights}\r\n";
            if (!string.IsNullOrEmpty(addcopyrightinfo)) settings += $"#AddCopyrightInfo={addcopyrightinfo}\r\n";
            if (ccli > 0) settings += $"#CCLI={ccli}\r\n";
            if (!string.IsNullOrEmpty(editor)) settings += $"#Editor={editor}\r\n";
            if (!string.IsNullOrEmpty(bible)) settings += $"#Bible={bible}\r\n";
            if (!string.IsNullOrEmpty(categories)) settings += $"#Categories={categories}\r\n";
            if (!string.IsNullOrEmpty(keywords)) settings += $"#Keywords={keywords}\r\n";
            if (!string.IsNullOrEmpty(quickfind)) settings += $"#QuickFind={quickfind}\r\n";
            if (churchsongid > 0) settings += $"#ChurchSongID={churchsongid}\r\n";
            if (!string.IsNullOrEmpty(comment)) settings += $"#Comment={comment}\r\n";
            if (!string.IsNullOrEmpty(comments)) settings += $"#Comments={comments}\r\n";
            if (!string.IsNullOrEmpty(key)) settings += $"#Key={key}\r\n";
            if (!string.IsNullOrEmpty(verseorder)) settings += $"#VerseOrder={verseorder}\r\n";
            if (!string.IsNullOrEmpty(songbook)) settings += $"#Songbook={songbook}\r\n";
            if (langcount > 0) settings += $"#LangCount={langcount}\r\n";
            if (!string.IsNullOrEmpty(lang)) settings += $"#Lang={lang}\r\n";
            if (tempo > 0) settings += $"#Tempo={tempo}\r\n";
            if (titlelang is not null)
            {
                for (var i = 0; i < titlelang.Length; i++)
                {
                    if (!string.IsNullOrEmpty(titlelang[i])) settings += $"#TitleLang{i + 2}={titlelang[i]}\r\n";
                }
            }
            if (!string.IsNullOrEmpty(otitle)) settings += $"#OTitle={otitle}\r\n";
            if (!string.IsNullOrEmpty(backgroundimage)) settings += $"#BackgroundImage={backgroundimage}\r\n";
            if (!string.IsNullOrEmpty(font)) settings += $"#Font={font}\r\n";
            if (fontlang is not null)
            {
                for (var i = 0; i < fontlang.Length; i++)
                {
                    if (!string.IsNullOrEmpty(fontlang[i])) settings += $"#FontLang{i + 2}={fontlang[i]}\r\n";
                }
            }
            if (fontsize > 0) settings += $"#FontSize={fontsize}\r\n";
            if (!string.IsNullOrEmpty(textalign)) settings += $"#TextAlign={textalign}\r\n";
            if (!string.IsNullOrEmpty(titlealign)) settings += $"#TitleAlign={titlealign}\r\n";
            if (!string.IsNullOrEmpty(settings)) settings += "---";
            return settings;
        }

        /// <summary>
        /// generates and returns the complete SNG file
        /// </summary>
        /// <param name="properties">the properties of the song in the right Format (like getProperties is returning)</param>
        /// <param name="slides">the slides of the song splitted by three hyphens</param>
        public static string GenerateCompleteSngFile(string properties, string slides)
        {
            return $"{properties}\r\n{slides}";
        }

        /// <summary>
        /// generates and returns the complete SNG file
        /// </summary>
        /// <param name="title">song title</param>
        /// <param name="author">name of the lyrics author</param>
        /// <param name="melody">name of componist</param>
        /// <param name="translation">name of translation author</param>
        /// <param name="c">copyright information</param>
        /// <param name="natcopyright">national copyright information</param>
        /// <param name="rights">additional rights (e.g. for translated lyrics)</param>
        /// <param name="addcopyrightinfo">additional copyright information</param>
        /// <param name="ccli">CCLI number</param>
        /// <param name="editor">name of editing program</param>
        /// <param name="bible">bible passage the text is based on</param>
        /// <param name="categories">categories the song is about</param>
        /// <param name="keywords">search keywords</param>
        /// <param name="quickfind">quick find string like STTN for "Shout to the North"</param>
        /// <param name="churchsongid">internal ID</param>
        /// <param name="comment">arbitrary comment</param>
        /// <param name="comments">Comment encoded with base64</param>
        /// <param name="key">mus. key of the song</param>
        /// <param name="verseorder">order of the song parts</param>
        /// <param name="songbook">also written: SongBook</param>
        /// <param name="langcount">number of translations in song file</param>
        /// <param name="lang">language of the song</param>
        /// <param name="tempo">tempo of the song</param>
        /// <param name="titlelang">song title in other language</param>
        /// <param name="otitle">original title</param>
        /// <param name="backgroundimage">Path to background relative to image folder. Observed file types: JPEG, PNG, BMP, WMV, AVI</param>
        /// <param name="font">font for lyrics</param>
        /// <param name="fontlang">font for other lyrics</param>
        /// <param name="fontsize">font size for lyrics</param>
        /// <param name="textalign">text alignment</param>
        /// <param name="titlealign">title alignment</param>
        /// <param name="slides">the slides of the song splitted by three hyphens</param>
        /// <remarks>Quelle: http://wiki.openlp.org/Development:SongBeamer_-_Song_Data_Format#Properties</remarks>
        public static string GenerateCompleteSngFile(string? title, string? author, string? melody,
                        string? translation, string? c, string? natcopyright, string? rights,
                        string? addcopyrightinfo, int ccli,
                        string? editor, string? bible, string? categories,
                        string? keywords, string? quickfind, int churchsongid,
                        string? comment, string? comments, string? key, string? verseorder,
                        string? songbook, int langcount, string? lang, int tempo,
                        string[]? titlelang, string? otitle, string? backgroundimage,
                        string? font, string[]? fontlang, int fontsize, string? textalign,
                        string? titlealign, string slides)
        {
            var properties = GenerateProperties(title, author, melody, translation,
                                c, natcopyright, rights, addcopyrightinfo, ccli, editor,
                                bible, categories, keywords, quickfind, churchsongid,
                                comment, comments, key, verseorder, songbook, langcount, lang,
                                tempo, titlelang, otitle, backgroundimage,
                                font, fontlang, fontsize, textalign, titlealign);
            if (properties.Trim() == string.Empty)
            {
                return slides;
            }
            return GenerateCompleteSngFile(properties, slides);
        }

        public static Dictionary<string, string> Parse(string file, Encoding encoding, bool content = false)
        {
            if (!content)
            {
                file = File.ReadAllText(file, encoding);
            }
            file = file.Replace("\r\n", "\n").Replace("\r", "\n");
            var dic = new Dictionary<string, string>();
            var slides = string.Empty;
            foreach (var line in file.Split('\n'))
            {
                if (line.StartsWith('#'))
                {
                    if (line.StartsWith("#Title=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("title", line["#Title=".Length..]);
                    }
                    if (line.StartsWith("#Author=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("author", line["#Author=".Length..]);
                    }
                    if (line.StartsWith("#Melody=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("melody", line["#Melody=".Length..]);
                    }
                    if (line.StartsWith("#Translation=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("translation", line["#Translation=".Length..]);
                    }
                    if (line.StartsWith("#(c)=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("c", line["#(c)=".Length..]);
                    }
                    if (line.StartsWith("#NatCopyright=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("natcopyright", line["#NatCopyright=".Length..]);
                    }
                    if (line.StartsWith("#Rights=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("rights", line["#Rights=".Length..]);
                    }
                    if (line.StartsWith("#AddCopyrightInfo=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("addcopyrightinfo", line["#AddCopyrightInfo=".Length..]);
                    }
                    if (line.StartsWith("#CCLI=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("ccli", line["#CCLI=".Length..]);
                    }
                    if (line.StartsWith("#Editor=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("editor", line["#Editor=".Length..]);
                    }
                    if (line.StartsWith("#Bible=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("bible", line["#Bible=".Length..]);
                    }
                    if (line.StartsWith("#Categories=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("categories", line["#Categories=".Length..]);
                    }
                    if (line.StartsWith("#Keywords=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("keywords", line["#Keywords=".Length..]);
                    }
                    if (line.StartsWith("#QuickFind=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("quickfind", line["#QuickFind=".Length..]);
                    }
                    if (line.StartsWith("#ChurchSongID=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("churchsongid", line["#ChurchSongID=".Length..]);
                    }
                    if (line.StartsWith("#Comment=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("comment", line["#Comment=".Length..]);
                    }
                    if (line.StartsWith("#Comments=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("comments", line["#Comments=".Length..]);
                    }
                    if (line.StartsWith("#Key=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("key", line["#Key=".Length..]);
                    }
                    if (line.StartsWith("#VerseOrder=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("verseorder", line["#VerseOrder=".Length..]);
                    }
                    if (line.StartsWith("#Songbook=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("songbook", line["#Songbook=".Length..]);
                    }
                    if (line.StartsWith("#LangCount=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("langcount", line["#LangCount=".Length..]);
                    }
                    if (line.StartsWith("#Lang=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("lang", line["#Lang=".Length..]);
                    }
                    if (line.StartsWith("#Tempo=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("tempo", line["#Tempo=".Length..]);
                    }
                    if (line.StartsWith("#TitleLang=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("titlelang", line["#TitleLang=".Length..]);
                    }
                    if (line.StartsWith("#OTitle=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("otitle", line["#OTitle=".Length..]);
                    }
                    if (line.StartsWith("#BackgroundImage=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("backgroundimage", line["#BackgroundImage=".Length..]);
                    }
                    if (line.StartsWith("#Font=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("font", line["#Font=".Length..]);
                    }
                    if (line.StartsWith("#FontLang=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("fontlang", line["#FontLang=".Length..]);
                    }
                    if (line.StartsWith("#FontSize=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("fontsize", line["#FontSize=".Length..]);
                    }
                    if (line.StartsWith("#TextAlign=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("textalign", line["#TextAlign=".Length..]);
                    }
                    if (line.StartsWith("#TitleAlign=", StringComparison.InvariantCultureIgnoreCase))
                    {
                        dic.Add("titlealign", line["#TitleAlign=".Length..]);
                    }
                }
                else
                {
                    if (slides == string.Empty)
                    {
                        if (line != "---")
                        {
                            slides = line;
                        }
                    }
                    else
                    {
                        slides += $"\r\n{line}";
                    }
                }
            }
            dic.Add("slides", slides);
            return dic;
        }

        public static Dictionary<string, string> Parse(string file, bool content = false)
        {
            return Parse(file, Encoding.Default, content);
        }

        public static string GetEnglishWord(string germanWord)
        {
            return germanWord.ToLower() switch
            {
                "titel" => "Title",
                "autor" => "Author",
                "melodie" => "Melody",
                "übersetzung" => "Translation",
                "©" => "c",
                "national-©" => "NatCopyright",
                "zusatz-rechte" => "Rights",
                "Zusatz-©" => "AddCopyrightInfo",
                "ccli" => "CCLI",
                "editor" => "Editor",
                "bibel" => "Bible",
                "kategorieen" => "Categories",
                "stichworte" => "Keywords",
                "schnellsuche" => "QuickFind",
                "interne id" => "ChurchSongID",
                "kommentar" => "Comment",
                "kommentare" => "Comments",
                "schlüssel" => "Key",
                "reihenfolge" => "VerseOrder",
                "songbuch" => "Songbook",
                "übersetzungsanzahl" => "LangCount",
                "sprache" => "Lang",
                "tempo" => "Tempo",
                "titel - sprache-n" => "TitleLang",
                "originaltitel" => "OTitle",
                "hintergrundbild" => "BackgroundImage",
                "schrift" => "Font",
                "schrift - sprache-n" => "FontLang",
                "schriftgröße" => "FontSize",
                "textausrichtung" => "TextAlign",
                "titelausrichtung" => "TitleAlign",
                _ => germanWord
            };
        }
    }
}

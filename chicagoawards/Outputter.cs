using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;

namespace WE2017Awards
{
    class Outputter
    {
        private string awardsBookTitle = "\tAWARDS PRESENTED AT THE " + Form1.showYear + " CHICAGO SHOW" + Environment.NewLine + Environment.NewLine;
        string missingPhotoList = string.Empty;

        public void outputAwardsCount()
        {
            System.Data.DataTable goldWinners = DataAccess.getAwardsByPriority("BETWEEN 5 AND 5.9");
            System.Data.DataTable silverWinners = DataAccess.getAwardsByPriority("BETWEEN 6 AND 6.9");
            System.Data.DataTable bronzeWinners = DataAccess.getAwardsByPriority("BETWEEN 7 AND 7.9");
            System.Data.DataTable certificateWinners = DataAccess.getAwardsByPriority("BETWEEN 8 AND 8.9");
            System.Data.DataTable BasicCertificateWinners = DataAccess.getAwardsByPriority("= 10.1");
            System.Data.DataTable GeneralCertificateWinners = DataAccess.getAwardsByPriority("= 9.2");
            System.Data.DataTable GeneralMedalWinners = DataAccess.getAwardsByPriority("= 9.1");

            System.Data.DataTable JuniorCertificateWinners = DataAccess.getAwardsByPriority("= 15.2");
            System.Data.DataTable JuniorAwardWinners = DataAccess.getAwardsByPriority("= 15.1");

            System.Data.DataTable WargamesCertificateWinners = DataAccess.getAwardsByPriority("= 14.2");
            System.Data.DataTable WargamesAwardWinners = DataAccess.getAwardsByPriority("= 14.1");

            System.Data.DataTable AntiqueCertificateWinners = DataAccess.getAwardsByPriority("= 13.2");
            System.Data.DataTable AntiqueAwardWinners = DataAccess.getAwardsByPriority("= 13.1");

            System.Data.DataTable DisplayersCertificateWinners = DataAccess.getAwardsByPriority("= 12.2");
            System.Data.DataTable DisplayersAwardWinners = DataAccess.getAwardsByPriority("= 12.1");

            System.Data.DataTable ThemeCertificateWinners = DataAccess.getAwardsByPriority("= 11.2");
            System.Data.DataTable ThemeAwardWinners = DataAccess.getAwardsByPriority("= 11.1");


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FileName = "MMSI" + Form1.showYear + "AwardsCount.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    file.WriteLine("CHICAGO SHOW " + Form1.showYear + " AWARDS TOTALS\r\n");
                    file.WriteLine("ADVANCED LEVEL\r\n");
                    file.WriteLine("GOLD----------" + goldWinners.Rows.Count);
                    file.WriteLine("SILVER--------" + silverWinners.Rows.Count);
                    file.WriteLine("BRONZE--------" + bronzeWinners.Rows.Count);
                    file.WriteLine("CERTIFICATES--" + certificateWinners.Rows.Count);
                    file.WriteLine("\r\n_________________\r\n");
                    file.WriteLine("GENERAL LEVEL\r\n");
                    file.WriteLine("CERTIFICATES--" + GeneralCertificateWinners.Rows.Count);
                    file.WriteLine("MEDALS--------" + GeneralMedalWinners.Rows.Count);
                    file.WriteLine("\r\n_________________\r\n");
                    file.WriteLine("BASIC LEVEL\r\n");
                    file.WriteLine("CERTIFICATES--" + BasicCertificateWinners.Rows.Count);
                    file.WriteLine("\r\n_________________\r\n");
                    file.WriteLine("JUNIORS\r\n");
                    file.WriteLine("CERTIFICATES--" + JuniorCertificateWinners.Rows.Count);
                    file.WriteLine("AWARDS--------" + JuniorAwardWinners.Rows.Count);
                    file.WriteLine("\r\n_________________\r\n");
                    file.WriteLine("WAR GAMES\r\n");
                    file.WriteLine("CERTIFICATES--" + WargamesCertificateWinners.Rows.Count);
                    file.WriteLine("AWARDS--------" + WargamesAwardWinners.Rows.Count);
                    file.WriteLine("\r\n_________________\r\n");
                    file.WriteLine("ANTIQUE FIGURES\r\n");
                    file.WriteLine("CERTIFICATES--" + AntiqueCertificateWinners.Rows.Count);
                    file.WriteLine("AWARDS--------" + AntiqueAwardWinners.Rows.Count);
                    file.WriteLine("\r\n_________________\r\n");
                    file.WriteLine("DISPLAYERS\r\n");
                    file.WriteLine("CERTIFICATES--" + DisplayersCertificateWinners.Rows.Count);
                    file.WriteLine("AWARDS--------" + DisplayersAwardWinners.Rows.Count);
                    file.WriteLine("\r\n_________________\r\n");
                    file.WriteLine("THEME\r\n");
                    file.WriteLine("CERTIFICATES--" + ThemeCertificateWinners.Rows.Count);
                    file.WriteLine("AWARDS--------" + ThemeAwardWinners.Rows.Count);

                }
            }

        }

        public void outputPhotoNames()
        {
            System.Data.DataTable goldWinners = DataAccess.getAwardsByPriority("BETWEEN 5 AND 5.9");
            System.Data.DataTable BOSWinner = DataAccess.getAwardsByPriority("= 2");
            System.Data.DataTable ChicagoMedalWinners = DataAccess.getAwardsByPriority("= 1");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FileName = "MMSI" + Form1.showYear + "PhotoNames.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String previousPriority = "0";
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    file.WriteLine("CHICAGO SHOW " + Form1.showYear + " PHOTO NAMES LIST");
                    file.WriteLine("The photos for the pieces listed need to conform to the\r\n" +
                        "given naming convention to appear in the awards presentation.\r\n");
                    file.WriteLine("GOLD WINNERS");
                    foreach (DataRow row in goldWinners.Rows)
                    {
                        String first = row["FirstName"].ToString();
                        String last = row["LastName"].ToString();
                        String title = row["Title"].ToString();
                        String category = row["Award"].ToString();
                        String photoName = row["ID"].ToString();
                        String awardName = (from DataRow dr in DataAccess.awardCodes.Rows
                                            where (string)dr["Code"] == category
                                            select (string)dr["Award"]).FirstOrDefault();

                        if (category != previousPriority)
                        {
                            file.WriteLine("-----------------------------------------------------");
                            file.WriteLine(awardName.ToUpper());
                            previousPriority = category;
                        }
                        file.WriteLine("\t" + first + " " + last + "-" + title + "-" + photoName + ".jpg");
                    }

                }
            }
        }

        public void outputAwardsBook()
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FileName = "MMSI" + Form1.showYear + "AwardsBook.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    file.WriteLine(awardsBookTitle);
                    foreach (DataRow row in DataAccess.awardCodes.Rows)
                    {

                        file.WriteLine(addAppropriatePreamble(Convert.ToDouble(row["Priority"])));

                        file.WriteLine(row["Award"].ToString().ToUpper());
                        System.Data.DataTable tableOFAwards = DataAccess.getAwardsByType(row["Code"].ToString());

                        if (tableOFAwards.Rows.Count < 1)
                        { file.WriteLine("No awards given."); }
                        else
                        {
                            foreach (DataRow award in tableOFAwards.Rows)
                            {
                                if (new[] { "1", "3", "4" }.Contains(row["Priority"].ToString()))
                                {
                                    file.WriteLine("\t" + award["FirstName"].ToString() + " " +
                                    award["LastName"].ToString());
                                }
                                else
                                {
                                    file.WriteLine("\t" + award["FirstName"].ToString() + " " +
                                        award["LastName"].ToString() + " - " + award["Title"].ToString());
                                }
                            }
                        }
                        //file.WriteLine("   -    -    -    -    -    -    -");
                    }
                }
            }
        }

        //public bool outputHTMLAwardsPresentation()//This is the old html based presentation
        //{
        //    string templateText = string.Empty;
        //    string basePath = string.Empty;
        //    string slidesString = string.Empty;
        //    double priority;
        //    string category = string.Empty;
        //    string photoSlidesString = string.Empty;
        //    string missingslides = "<!--\r\nNO AWARD SLIDES CREATED FOR THE FOLLOWING CATEGORIES:\r\n";

        //    #region slideTemplates
        //    string categorySlide = "    <section class='slide'>\r\n" +
        //                           "       <div class='categoryContainer'>\r\n" +
        //                           "           <p><h1>*LINE1*</h1></p>\r\n" +
        //                           "       </div>\r\n" +
        //                           "    </section>\r\n";

        //    string awardSlide = "    <section class='slide'>\r\n" +
        //                        "       <h1>*CATEGORY*</h1>\r\n" +
        //                        "       <div class='entryContainer'>\r\n" +
        //                        "          <table class='entryTable'>\r\n" +
        //                        "             <tr>\r\n" +
        //                        "                <td class='entryImgTD'>\r\n" +
        //                        "                    <img src = '*PHOTOPATH*'  class='entryImgTbl'/>\r\n" +
        //                        "                    </td>\r\n" +
        //                        "                <td class='entryTxtTD'>\r\n" +
        //                        "                    <p>*NAME*</p>\r\n" +
        //                        "                    <p>*TITLE*</p>\r\n" +
        //                        "                </td>\r\n" +
        //                        "             </tr>\r\n" +
        //                        "          </table>\r\n" +
        //                        "       </div>\r\n" +
        //                        "    </section>\r\n";

        //    string oneWinnerSlide = "    <section class='slide'>\r\n" +
        //                           "       <h1>*CATEGORY*</h1>\r\n" +
        //                           "       <div class='oneWinnerContainer'>\r\n" +
        //                           "          <table class='entryTable'>\r\n" +
        //                           "             <tr>\r\n" +
        //                           "                <td class='oneWinnerTD'>\r\n" +
        //                           "                   <p>*NAME*</p>\r\n" +
        //                           "                </td>\r\n" +
        //                           "             </tr>\r\n" +
        //                           "          </table>\r\n" +
        //                           "       </div>\r\n" +
        //                           "    </section>\r\n";

        //    string twoWinnerSlide = "    <section class='slide'>\r\n" +
        //                              "       <h1>*CATEGORY*</h1>\r\n" +
        //                              "       <div class='twoWinnerContainer'>\r\n" +
        //                              "          <table class='entryTable'>\r\n" +
        //                              "             <tr>\r\n" +
        //                              "                <td class='twoWinnerTD'>\r\n" +
        //                              "                   <p>*NAME1*</p>\r\n" +
        //                              "                </td>\r\n" +
        //                              "                <td class='twoWinnerTD'>\r\n" +
        //                              "                   <p>*NAME2*</p>\r\n" +
        //                              "                </td>\r\n" +
        //                              "             </tr>\r\n" +
        //                              "          </table>\r\n" +
        //                              "       </div>\r\n" +
        //                              "    </section>\r\n";

        //    #endregion

        //    #region readTemplate
        //    try
        //    {
        //        MessageBox.Show("Select the file 'mmsiTemplate.html' in the presentation folder. \r\nThe presentation will be saved in the same folder.");
        //        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //        openFileDialog1.Filter = "html files (*.html)|*.html";
        //        openFileDialog1.FilterIndex = 2;
        //        openFileDialog1.Title = "Choose Template";
        //        openFileDialog1.RestoreDirectory = true;

        //        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            try
        //            {
        //                if (!openFileDialog1.FileName.Contains("mmsiTemplate.html"))
        //                {
        //                    throw new Exception("The file chosen must be mmsiTemplate.html.");
        //                }
        //                templateText = System.IO.File.ReadAllText(openFileDialog1.FileName);
        //                basePath = Path.GetDirectoryName(openFileDialog1.FileName);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        //                return false;
        //            }
        //        }

        //        #endregion

        //        string tempSlideStr = string.Empty;
        //        foreach (DataRow row in DataAccess.awardCodes.Rows)
        //        {
        //            priority = Convert.ToDouble(row["Priority"]);
        //            category = row["AwardLabel"].ToString();

        //            DataTable dtAwardsOfCurrPriority = DataAccess.getAwardsByPriority(" = " + priority.ToString());
        //            if (dtAwardsOfCurrPriority.Rows.Count > 0)
        //            {
        //                slidesString += "\r\n" + categorySlide.Replace("*LINE1*", category);
        //                if (priority >= 3 && priority < 5)
        //                {
        //                    tempSlideStr = oneWinnerSlide.Replace("*CATEGORY*", category);
        //                    tempSlideStr = tempSlideStr.Replace("*NAME*", dtAwardsOfCurrPriority.Rows[0]["FirstName"].ToString() +
        //                        " " + dtAwardsOfCurrPriority.Rows[0]["LastName"].ToString());
        //                    slidesString += tempSlideStr;
        //                }
        //                else if (priority < 5 && dtAwardsOfCurrPriority.Rows.Count == 2)
        //                {
        //                    tempSlideStr = twoWinnerSlide.Replace("*CATEGORY*", category);
        //                    tempSlideStr = tempSlideStr.Replace("*NAME1*", dtAwardsOfCurrPriority.Rows[0]["FirstName"].ToString() +
        //                        " " + dtAwardsOfCurrPriority.Rows[0]["LastName"].ToString());
        //                    tempSlideStr = tempSlideStr.Replace("*NAME2*", dtAwardsOfCurrPriority.Rows[1]["FirstName"].ToString() +
        //                        " " + dtAwardsOfCurrPriority.Rows[1]["LastName"].ToString());
        //                    slidesString += tempSlideStr;
        //                }
        //                else if ((priority >= 5 && priority < 6) || priority < 3)
        //                {
        //                    photoSlidesString = makePhotoSlides(basePath, awardSlide, dtAwardsOfCurrPriority, category);
        //                    slidesString += photoSlidesString;
        //                }
        //            }
        //            else// == no awards in category
        //            {
        //                missingslides += category + "\r\n";
        //            }
        //        }
        //        templateText = templateText.Replace("<!--MMSISLIDES-->", slidesString + "\r\n" + missingslides + "-->");

        //        System.IO.File.WriteAllText(basePath + "\\MMSI" + Form1.showYear + "AwardsPresentation.html", templateText);
        //        System.IO.File.WriteAllText(basePath + "\\MMSI" + Form1.showYear + "MissingPhotos.txt", missingPhotoList);
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show("Error: Could not create presentation. Original error: " + exc.Message);
        //        return false;
        //    }

        //    return true;
        //}



        public bool outputAwardsPresentation()
        {
            string templateText = string.Empty;
            string presentationTemplatePath = string.Empty;
            string slidesString = string.Empty;
            double priority;
            string basePath = string.Empty;
            string photoPath = string.Empty;
            string category = string.Empty;
            string photoSlidesString = string.Empty;
            string missingslides = "<!--\r\nNO AWARD SLIDES CREATED FOR THE FOLLOWING CATEGORIES:\r\n";

            try
            {
                MessageBox.Show("Select the file 'mmsiTemplate.ppt.' \r\nThe presentation will be saved in the same folderx.");
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "powerpoint files (*.ppt)|*.ppt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.Title = "Choose Template";
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (!openFileDialog1.FileName.Contains("mmsitemplate.ppt"))
                        {
                            throw new Exception("The file chosen must be mmsitemplate.ppt.");
                        }

                        presentationTemplatePath = openFileDialog1.FileName;
                        basePath = Path.GetDirectoryName(openFileDialog1.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                        return false;
                    }
                }

                Microsoft.Office.Interop.PowerPoint.Application pptApplication = new Microsoft.Office.Interop.PowerPoint.Application();

                Microsoft.Office.Interop.PowerPoint.Slides slides;
                Microsoft.Office.Interop.PowerPoint._Slide slide;
                Microsoft.Office.Interop.PowerPoint.TextRange objText;

               // Presentation  = pptApplication.Presentations.Add(MsoTriState.msoTrue);
                Presentation pptPresentation = pptApplication.Presentations.Open(presentationTemplatePath, MsoTriState.msoTrue);
                slides = pptPresentation.Slides;

                int sIndex = 0;
                foreach (DataRow row in DataAccess.awardCodes.Rows)
                {
                    priority = Convert.ToDouble(row["Priority"]);
                    category = row["AwardLabel"].ToString();

                    System.Data.DataTable dtAwardsOfCurrPriority = DataAccess.getAwardsByPriority(" = " + priority.ToString());
                    if (dtAwardsOfCurrPriority.Rows.Count > 0)
                    {

                         if ((priority >= 5 && priority < 6)) //Gold Awards
                           {
                            foreach (DataRow award in dtAwardsOfCurrPriority.Rows) {

                                //get correct slide ID so we know where to place the slide:
                                switch (row["Code"].ToString())
                                {
                                    case "VPG":
                                        sIndex = 358;
                                        break;
                                    case "VOG":
                                        sIndex = 359;
                                        break;
                                    case "HPG":
                                        sIndex = 361;
                                        break;
                                    case "HOG":
                                        sIndex = 540;
                                        break;
                                    case "FPG":
                                        sIndex = 354;
                                        break;
                                    case "FOG":
                                        sIndex = 360;
                                        break;
                                    default:
                                        sIndex = 0;
                                        break;
                                }
 
                            // Create new Slide
                            Microsoft.Office.Interop.PowerPoint._Slide OOGTitleSlide = slides.FindBySlideID(sIndex);
                            int PlacementIndex = OOGTitleSlide.SlideIndex;
                            slide = slides.AddSlide(PlacementIndex, pptPresentation.SlideMaster.CustomLayouts[1]);

                            // Add title
                            objText = slide.Shapes[1].TextFrame.TextRange;
                            objText.Text = row["Award"].ToString();
                            objText.Font.Name = "Lucida Sans";
                            objText.Font.Size = 40;

                            objText = slide.Shapes[2].TextFrame.TextRange;
                            objText.Text = award["FirstName"] + " " + award["LastName"] + "\n\n" + award["Title"].ToString();

                            Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];
                                if (System.IO.File.Exists(basePath + "/entryImages/" + award["ID"].ToString() + ".jpg"))
                                {
                                    photoPath = basePath + "/entryImages/" + award["ID"].ToString() + ".jpg";
                                }
                                else
                                {
                                    photoPath = basePath + "/miscImages/GoldMedal.png";
                                    missingPhotoList += award["ID"].ToString() + "\r\n";
                                }
                                slide.Shapes.AddPicture(photoPath, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 20, shape.Top, shape.Width, shape.Height);
                            }
                        }
                    }
                    else// == no awards in category
                    {
                        missingslides += category + "\r\n";
                    }
                }

                //now add best of show slide
                System.Data.DataTable dtBOS = DataAccess.getAwardsByPriority(" = 2");
                if (dtBOS.Rows.Count > 0)
                {

                    Microsoft.Office.Interop.PowerPoint._Slide OOGTitleSlide = slides.FindBySlideID(364);
                    int PlacementIndex = OOGTitleSlide.SlideIndex;
                    slide = slides.AddSlide(PlacementIndex, pptPresentation.SlideMaster.CustomLayouts[1]);

                    // Add title
                    objText = slide.Shapes[1].TextFrame.TextRange;
                    objText.Text = "Best of Show";
                    objText.Font.Name = "Lucida Sans";
                    objText.Font.Size = 40;

                    objText = slide.Shapes[2].TextFrame.TextRange;
                    objText.Text = dtBOS.Rows[0]["FirstName"] + " " + dtBOS.Rows[0]["LastName"] + "\n\n" + dtBOS.Rows[0]["Title"].ToString();

                    Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];
                    if (System.IO.File.Exists(basePath + "/entryImages/" + dtBOS.Rows[0]["ID"].ToString() + ".jpg"))
                    {
                        photoPath = basePath + "/entryImages/" + dtBOS.Rows[0]["ID"].ToString() + ".jpg";
                    }
                    else
                    {
                        photoPath = basePath + "/miscImages/GoldMedal.png";
                        missingPhotoList += dtBOS.Rows[0]["ID"].ToString() + "\r\n";
                    }
                    slide.Shapes.AddPicture(photoPath, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 20, shape.Top, shape.Width, shape.Height);
                }

                //Now add Chicago Medalist(s)
                System.Data.DataTable dtCM = DataAccess.getAwardsByPriority(" = 1");
                if (dtCM.Rows.Count > 0 && dtCM.Rows.Count < 3)
                {

                    Microsoft.Office.Interop.PowerPoint._Slide OOGTitleSlide = slides.FindBySlideID(364);
                    int PlacementIndex = OOGTitleSlide.SlideIndex + 1;
                    slide = slides.AddSlide(PlacementIndex, pptPresentation.SlideMaster.CustomLayouts[2]);

                    // Add title
                    objText = slide.Shapes[1].TextFrame.TextRange;
                    objText.Text = "Chicago Medal";
                    objText.Font.Name = "Lucida Sans";
                    objText.Font.Size = 40;

                    objText = slide.Shapes[2].TextFrame.TextRange;
                    objText.Text = dtCM.Rows[0]["FirstName"] + " " + dtCM.Rows[0]["LastName"];
                    Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];

                    if (dtCM.Rows.Count == 2) { 
                    objText = slide.Shapes[3].TextFrame.TextRange;
                    objText.Text = dtCM.Rows[1]["FirstName"] + " " + dtCM.Rows[1]["LastName"];
                    Microsoft.Office.Interop.PowerPoint.Shape secShape = slide.Shapes[3];
                     }

                }

                pptPresentation.SaveAs(Path.GetDirectoryName(presentationTemplatePath) + @"\MMSI" + Form1.showYear + ".pptx", PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
                pptPresentation.Close();
                pptApplication.Quit();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: Could not create presentation. Original error: " + exc.Message);
                return false;
            }


            return true;
        }


        private string addAppropriatePreamble(Double priority)
        {

            #region preambleStrings
            string separatingLine = "____________________________________________________________";

            string showCommitteePreamble = "THE SHOW COMMITTEE AWARDS\r\n\r\n   Our first awards are presented" +
                   " in areas outside the scope of the Main awards,\r\nor in which the show committee wishes to encourage interest." + Environment.NewLine;
            string basicLevelPreamble = "\r\nAWARDS AT THE BASIC LEVEL\r\n\r\n" +
                   "   These awards are given to recognize achievement by painters of modest ablility,\r\n" +
                   "Whatever their level of experience.";
            string generalLevelPreamble = "\r\nAWARDS AT THE GENERAL LEVEL\r\n\r\n" +
                   "   These Awards recognize work by modelers with more developed skills who\r\n" +
                   "do not feel they are quite ready for the Advanced Level.\r\n" +
                   "Two kinds of award are given: certificates of merit and pewter medals";
            string advancedLevelPreamble = "\r\nAWARDS AT THE ADVANCED LEVEL\r\n\r\n" +
                "  Awards at this level are divided into three Divisions: Ordnance, Painters,\r\n" +
                "and Open.  There are no categories of any kind in any of the Divisions.\r\n" +
                "All exhibits are eligible for the same awards.\r\n\r\n" +
                "  The Ordnance Division is for vehicles, aircraft, and other entries without figures.\r\n" +
                "The Painters Division is for painted figures, and is judged entirely on painting\r\n" +
                "skill. Scratchbuilt and converted figures may be entered, but enjoy no advantage\r\n" +
                "over stock commercial kits. The Open Division is intended for converted and\r\n" +
                "scratchbuilt figures, dioramas, and vignettes.\r\n\r\n" +
                "  The Divisions are judged separately. Each exhibit is viewed by three judges.\r\n" +
                "Together, the judges select what they feel is the best piece or group of pieces\r\n" +
                "by each exhibitor. The Judges then separate and score the selected exhibits\r\n" +
                "individually, awarrding zero to four points to each.\r\n\r\n" +
                "  Their scores are then compared by the Awards Committee. A piece achieving\r\n" +
                "at least 11 of 12 possible points from the three judges receives a Gold Medal,\r\n" +
                "8 to 20 points a Silver Medal, 5 to 7 points a Bronze Medal, and 1 to 4 points\r\n" +
                "a Certificate of Merit.\r\n\r\n" +
                "  We would like to emphasize that Gold, Silver and Bronze do not in any way\r\n" +
                "represent first, second or third place. All the judges do is rank the pieces\r\n" +
                "in the show in four levels of achievement. The standard against which pieces\r\n" +
                "are measured is set by award winners at that level in previous years.\r\n\r\n" +
                "  This means that that this is not a competition at all. Nobody wins an award at\r\n" +
                "anyone else's expense. We give as many Gold Medals as the quality of the work\r\n" +
                "demands, whether that be two or twenty, and the same is true of all the other\r\n" +
                "awards given at this show.\r\n\r\n" +
                "CERTIFICATES OF MERIT\r\n\r\n" +
                "  Our first awards at the Advanced level are the Certificates of Merit.\r\n" +
                "These are given to exhibits which did not qualify for medals, but which the\r\n" +
                "judges felt were of such high quality that they deserve recognition.\r\n";
            string ShellySteinPreamble = "THE SHELLY STEIN AWARD\r\n\r\n" +
                "  Much credit is given -- and rightly so -- to those who organize the clubs\r\n" +
                "and run the shows that make this hobby so enjoyable for all of us. But it is\r\n" +
                "the core group of friends who come every year, unheralded and unannounced, who\r\n" +
                "make these shows a success.  These people rarely win top awards for their figures,\r\n" +
                "but they bring new pieces for display every year. When the call goes out for\r\n" +
                "volunteers, they never hesitate to step forward, even if their contributions of\r\n" +
                "time an energy often go unnoticed.\r\n\r\n" +
                "  Shelly Stein embodied this spirit better than anyone in our organization, which\r\n" +
                "makes it especially meaningful that the award given in his memory recognizes the\r\n" +
                "importance and achievements of the average hobbyist.\r\n\r\n" +
                "This year’s winner has been quietly supporting the hobby for years, so quietly in fact,\r\n" +
                "that his name may not be familiar to many. But his face is well known to many of us,\r\n" +
                "and we are please to acknowledge the contribution of\r\n";
            string ArchJacksonPreamble = "THE ARCHER JACKSON AWARD\r\n\r\n" +
                "   All of the work involved in running the society, publishing the Scabbard, and\r\n" +
                "putting on the show is done by volunteers, many of whom have been quietly giving\r\n" +
                "their time and energy for years with little or no recognition.\r\n\r\n" +
                "   Although many members contribute to club activities, there are always a few\r\n" +
                "who are so generous with their time and efforts that the whole endeavor would\r\n" +
                "probably collapse without them.\r\n\r\n" +
                "   No one better exemplified this spririt than the late Archer Jackson, who served\r\n" +
                "for many years as our treasurer. \r\n" +
                "  This award is our small way of saying 'Thank you, and well done.'\r\n\r\n" +
                "          (CALL ON THE M.M.S.I. PRESIDENT TO PRESENT THE AWARD)\r\n";
            string bestOfShowPreamble = "THE BEST OF SHOW\r\n\r\n" +
                "The Best of Show is decided by a combined vote of the judges and exhibitors.\r\n";
            string ChicagoMedalPreamble = "THE CHICAGO MEDAL\r\n\r\n" +
                "  The Chicago Medal is our highest award, in that it is given for consistent\r\n" +
                "excellence over a period of years.\r\n\r\n" +
                "  Of the many exhibitors who display their work at this show every year, there are\r\n" +
                "a select few whose work has a special quality that leaves a lasting impression on\r\n" +
                "everyone who sees it. These people are clearly in a class by themselves, and\r\n" +
                "this award is our way of recognizing that fact.\r\n\r\n" +
                "  The Chicago Medalists are the people who, by the example they set each year,\r\n" +
                "expand the horizons of the hobby and set the standards by which we judge\r\n" +
                "ourselves.\r\n\r\n" +
                "  Recipients are chosen by vote of the current holders of the medal.\r\n";
            string bronzePreamble = "\r\nBRONZE MEDALS\r\n\r\n" +
                "Bronze medals are awarded to exhibits receiving 5 to 7 points from the judges.";
            string silverPreamble = "\r\nSILVER MEDALS\r\n\r\n" +
                "Silver medals are awarded to exhibits receiving 8 to 10 points from the judges.";
            string goldPreamble = "\r\nGOLD MEDALS\r\n\r\n" +
                "Gold medals are awarded to exhibits receiving 11 or 12 points from the judges.";
            #endregion

            if (priority == 15.2) { return showCommitteePreamble; }
            if (priority == 10.1) { return separatingLine + Environment.NewLine + basicLevelPreamble + Environment.NewLine; }
            if (priority == 9.2) { return separatingLine + Environment.NewLine + generalLevelPreamble + Environment.NewLine; }
            if (priority == 8.6) { return separatingLine + Environment.NewLine + advancedLevelPreamble + Environment.NewLine; }
            if (priority == 7.6) { return separatingLine + Environment.NewLine + bronzePreamble + Environment.NewLine; }
            if (priority == 6.6) { return separatingLine + Environment.NewLine + silverPreamble + Environment.NewLine; }
            if (priority == 5.6) { return separatingLine + Environment.NewLine + goldPreamble + Environment.NewLine; }
            if (priority == 4) { return separatingLine + Environment.NewLine + ShellySteinPreamble + Environment.NewLine; }
            if (priority == 3) { return separatingLine + Environment.NewLine + ArchJacksonPreamble + Environment.NewLine; }
            if (priority == 2) { return separatingLine + Environment.NewLine + bestOfShowPreamble + Environment.NewLine; }
            if (priority == 1) { return separatingLine + Environment.NewLine + ChicagoMedalPreamble + Environment.NewLine; }
            return string.Empty;
        }

        //private string makePhotoSlides(string basePath, string awardSlide, System.Data.DataTable awardsInCategory, string category)
        //{
        //    string returnString = string.Empty;
        //    string photoPath = string.Empty;

        //    foreach (DataRow row in awardsInCategory.Rows)
        //    {
        //        if (System.IO.File.Exists(basePath + "/entryImages/" + row["ID"].ToString() + ".jpg"))
        //        {
        //            photoPath = "entryImages/" + row["ID"].ToString() + ".jpg";
        //        }
        //        else
        //        {
        //            photoPath = "images/GoldMedal.png";
        //            missingPhotoList += row["ID"].ToString() +  "\r\n";
        //        }
        //        returnString += awardSlide.Replace("*PHOTOPATH*", photoPath);
        //        returnString = returnString.Replace("*NAME*", row["FirstName"].ToString() + " " + row["LastName"].ToString());
        //        returnString = returnString.Replace("*TITLE*", row["Title"].ToString());
        //        returnString = returnString.Replace("*CATEGORY*", category);
        //    }
        //    return returnString;
        //}

    }
}

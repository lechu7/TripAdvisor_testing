using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripAdvisor_testing
{
    class Generator : BaseTest
    {
        List<String> returnedList;
        List<String> listOfObjects;
        List<String> listOfDescription;

        public List<String> readFromFile(String path)
        {
            returnedList = new List<string>();

            string line;
            System.IO.StreamReader file =new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                returnedList.Add(line);
            }

            file.Close();
            return returnedList;
        }
       [Test]
       public void Gen()
        {
            string  startupPath = AppDomain.CurrentDomain.BaseDirectory;
            Random random = new Random();

            int countOfImage = 16;

            for (int i = 0; i < 10; i++)
            {

                //Generowanie list
                string listOfObjectPath = startupPath + "\\Generator_Atrakcji\\Restauracje.txt";
                listOfObjects = readFromFile(listOfObjectPath);
                string listOfDescriptionPath = startupPath + "\\Generator_Atrakcji\\Opis.txt";
                listOfDescription = readFromFile(listOfDescriptionPath);


                //Wybieranie nazwy
                String nameOfObject = listOfObjects[random.Next(0, listOfObjects.Count)];
                //Wybieranie opisu
                String descriptionOfObject = listOfDescription[random.Next(0, listOfDescription.Count)];
                //Wybieranie obrazka
                String imageOfObject = startupPath + "\\Obrazki\\"+random.Next(1,countOfImage)+".jpg";

                String width;
                int widthTMP = random.Next(20, 22);
                if (widthTMP==20)
                {
                    width = Convert.ToString(widthTMP) + "." + Convert.ToString(random.Next(9258231, 9999999));
                }
                else
                {
                    width = Convert.ToString(widthTMP) + "." + Convert.ToString(random.Next(0, 0853664));
                }

                String height;
                height = "52." + Convert.ToString(random.Next(1661351, 2854656));

                Console.WriteLine("Dane - Nazwa: '"+nameOfObject+"' , opis: '"+descriptionOfObject+"', obrazek: '"+imageOfObject+"', szerokosc: '"+width+"', wysokość: '"+height+"'.");


                //MainPageAction mainPageAction = new MainPageAction(driver);
                //LoginPageAction loginPageAction = new LoginPageAction(driver);
                //AtractionPageAction atractionPageAction = new AtractionPageAction(driver);

                //mainPageAction.clickDodajAtrakcjeBT();
                //loginPageAction.positiveLogin();
                //mainPageAction.clickDodajAtrakcjeBT();
                //atractionPageAction.nazwaETSet(nameOfObject);
                //atractionPageAction.opisETSet(descriptionOfObject);
                //atractionPageAction.localizationBTClick();
                //atractionPageAction.widthSet(width);
                //atractionPageAction.heightSet(width);
                //atractionPageAction.imageETSet(imageOfObject);
                //atractionPageAction.sendBTClick();

            }
   
        }
    }
}

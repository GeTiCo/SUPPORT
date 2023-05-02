using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;

namespace BubblesTea
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Excel.Application excelApp;     //Подключение приложение Excel
        public static Excel.Workbook excelWorkBook;   //Подключение отдельной книги
        public static Excel.Worksheet excelWorkSheet; //Подключение листов
        public static Excel.Range excelRange;         //Подключение используемых ячеек

        public static int SummaOrder { get; set; }
        public static int SummaBankCard { get; set; }

        public static string pathExe = Environment.CurrentDirectory;  //Путь к дерриктории
        public static string fileMenu = pathExe + @"/swimsuits.xlsx"; //Путь к директории + имя книги
    }
}

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrintData
{
    public partial class FormDataManager : Form
    {
        bool IdAscDesc = false;   // true = Asc, false = Desc
        bool BalAscDesc = false;
        delegate void WorkToDoList<T>(List<T> dataList);
        WorkToDoList<Account> workList = null;


        public FormDataManager()
        {
            InitializeComponent();
        }

        // Button Logic

        private void btnShowData_Click(object sender, EventArgs e)
        {
            lbxShowData.Items.Clear();
            ShowData();
            EnableButtons();
        } 

        private void btnSortByID_Click(object sender, EventArgs e)
        {            
            SortByID();
        }

        private void btnSortByBal_Click(object sender, EventArgs e)
        {
            SortByBal();
        }

        private void btnCreateDocument_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }

        private void EnableButtons()
        {
            btnSortByID.Enabled = true;
            btnSortByBal.Enabled = true;
            btnCreateDocument.Enabled = true;
        }


        // Data Appearance handling

        private void ShowData()
        {

            var listData = UserData.GetData();
            foreach (var item in listData)
            {
                lbxShowData.Items.Add($"ID: {item.ID}   |   Balance: {item.Balance}");                
            }
        }

        private void SortByID()
        {
            IdAscDesc = !IdAscDesc;
            var UnsortedList = UserData.GetData();
            IOrderedEnumerable<Account> resultList;
            if (IdAscDesc)
            {
                resultList = from n
                     in UnsortedList
                             orderby n.ID ascending
                             select n;
                
                lbxShowData.Items.Clear();
            }
            else
            {
                resultList = from n
                     in UnsortedList
                             orderby n.ID descending
                             select n;
                
                lbxShowData.Items.Clear();
            }

            foreach (var item in resultList)
            {
                lbxShowData.Items.Add($"ID: {item.ID}   |   Balance: {item.Balance}");
            }
        }

        private void SortByBal()
        {
            BalAscDesc = !BalAscDesc;
            var UnsortedList = UserData.GetData();
            IOrderedEnumerable<Account> resultList;
            if (BalAscDesc)
            {
                resultList = from n
                     in UnsortedList
                             orderby n.Balance ascending
                             select n;
                
                lbxShowData.Items.Clear();
            }
            else
            {
                resultList = from n
                     in UnsortedList
                             orderby n.Balance descending
                             select n;
                
                lbxShowData.Items.Clear();
            }

            foreach (var item in resultList)
            {
                lbxShowData.Items.Add($"ID: {item.ID}   |   Balance: {item.Balance}");                
            }
        }


        static void DoWorkList<T>(List<T> dataList, WorkToDoList<T> workToDoList)
        {
            workToDoList(dataList);
        }


        // Create document type

        private void CreateDocument()
        {

            if (checkBoxTxt.Checked && lbxShowData.Items.Count > 0)
            {
                workList += PrintDocument.ToTxt;
            }
            if (checkBoxWord.Checked && lbxShowData.Items.Count > 0)
            {
                workList += PrintDocument.ToWord;
            }
            if (checkBoxExcel.Checked && lbxShowData.Items.Count > 0)
            {
                workList += PrintDocument.ToExcel;
            }
            if (checkBoxPDF.Checked && lbxShowData.Items.Count > 0)
            {
                workList += PrintDocument.ToPDF;
            }
            if (checkBoxTxt.Checked || checkBoxWord.Checked || checkBoxExcel.Checked || checkBoxPDF.Checked)
            {
                DoWorkList(UserData.GetData(), workList);
            }

        }
    }
}



public class Account
{
    public int ID { get; set; }
    public double Balance { get; set; }
}

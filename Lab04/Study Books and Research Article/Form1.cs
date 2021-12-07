using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_R_Books_System
{
    public partial class Form1 : Form
    {
        List<StudyBook> StudyBooks= new List<StudyBook>();
        List<ResearchArticle> ResearchArticles = new List<ResearchArticle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddSBOnClick(object sender, EventArgs e)
        {
            StudyBook studybook = new StudyBook();
            studybook.ID = SBIDTextBox.Text;
            studybook.Title = SBTitleTextBox.Text;
            studybook.Author = SBAuthorTextBox.Text;
            studybook.Publisher = SBPublisherTextBox.Text;
            studybook.Quantity = Convert.ToInt32(SBQuantityTextBox.Text);
            studybook.ISBN = SBISBNTextBox.Text;
            studybook.Genre = SBGenreTextBox.Text;
            StudyBooks.Add(studybook);
            MessageBox.Show("Study Book added.");
        }

        private void AddRAOnClick(object sender, EventArgs e)
        {
            ResearchArticle researcharticle = new ResearchArticle();
            researcharticle.ID = RAIDTextBox.Text;
            researcharticle.Title = RATitleTextBox.Text;
            researcharticle.Author = RAAuthorTextBox.Text;
            researcharticle.Publisher = RAPublisherTextBox.Text;
            researcharticle.Quantity = Convert.ToInt32(RAQuantityTextBox.Text);
            researcharticle.DOI = RADOITextBox.Text;
            researcharticle.PubDate= RAPubDateTextBox.Text;
            researcharticle.Type = RATypeTextBox.Text;
            ResearchArticles.Add(researcharticle);
            MessageBox.Show("Research Article added.");
        }

        private void BorrowSBOnClick(object sender, EventArgs e)
        {
            foreach(StudyBook studybook in StudyBooks)
            {
                if (SBIDTextBox2.Text == studybook.ID)
                    studybook.Quantity--;
            }
        }

        private void BorrowRAOnClick(object sender, EventArgs e)
        {
            foreach (ResearchArticle researcharticle in ResearchArticles)
            {
                if (RAIDTextBox2.Text == researcharticle.ID)
                    researcharticle.Quantity--;
            }
        }

        private void ShowSBOnClick(object sender, EventArgs e)
        {
            StudyBookListBox.Items.Clear();
            foreach(StudyBook studybook in StudyBooks)
            {
                StudyBookListBox.Items.Add(studybook.GetInfo());
            }
        }

        private void ShowRAOnClick(object sender, EventArgs e)
        {
            ResearchArticleListBox.Items.Clear();
            foreach (ResearchArticle researcharticle in ResearchArticles)
            {
                ResearchArticleListBox.Items.Add(researcharticle.GetInfo());
            }
        }
    }
}

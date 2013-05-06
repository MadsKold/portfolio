using MVVMTest.Helpers;
using MVVMTest.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DataAccessLayer;

namespace MVVMTest.ViewModel
{
    public class ZipViewModel : ViewModelBase
    {
        //Instantiere RelayCommands
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand AddSampleCommand { get; private set; }
        public RelayCommand ClearTextCommand { get; private set; }
        public RelayCommand ClearText1Command { get; private set; }

        //Instantiere privat Zipcode object
        private Zipcode model = new Zipcode();

        //Declarerer list ObservableCollection af typen Zipcode
        private ObservableCollection<Zipcode> data;

        //Instantiere DB-context object
        ZipCodeDataDataContext db = new ZipCodeDataDataContext();

        public ZipViewModel()
        {
            //Instantiere RelayCommands
            AddCommand = new RelayCommand(p => Add());
            AddSampleCommand = new RelayCommand(p => AddSample());            
            ClearTextCommand = new RelayCommand(p => ClearText());  
            ClearText1Command = new RelayCommand(p => ClearText1());

            //Instantiere list af typen Zipcode
            Data = new ObservableCollection<Zipcode>();

            FindData();
        }

        //Henter data fra databasen via LINQ
        public void FindData()
        {
            //var r = (from m in db.ZipCodeEntities select m);
            foreach (var item in db.ZipCodeEntities.Select(z => z))
            {
                //Fylder data fra DB objecter til Zipcode objecter
                Data.Add(new Zipcode(item.Ziocode.ToString(), item.City));
            }
        }

        //Gemmer data fra databasen via LINQ
        public void Add()
        {    
                //Nyt DB  object
                ZipCodeEntity zipcode = new ZipCodeEntity();
                zipcode.Ziocode = Convert.ToInt32(Code);
                zipcode.City = City;

                //Indsæt object ind in DB
                db.ZipCodeEntities.InsertOnSubmit(zipcode);
                db.SubmitChanges();

                FindData();
        }


        //Tilføjer demodata til DB
        public void AddSample()
        {
            int zip = 2300;
            for (int i = 0; i < 100; i++)
            {
                zip += 45;
                ZipCodeEntity zipcode = new ZipCodeEntity();
                zipcode.Ziocode = zip;
                zipcode.City = "By" + zip;

                db.ZipCodeEntities.InsertOnSubmit(zipcode);
                db.SubmitChanges();
            }

            FindData();
        }

        //Textbox1 Clear text
        public void ClearText()
        {
            Code = "";            
        }

        //Textbox2 Clear text
        public void ClearText1()
        {          
            City = "";
        }

        public ObservableCollection<Zipcode> Data
        {
            get { return data; }
            set
            {
                if (data != value)
                {
                    data = value;
                    OnPropertyChanged("Data");
                }
            }
        }

        
        public string Code
        {
            get { return model.Code; }
            set
            {
                if (!model.Code.Equals(value))
                {
                    model.Code = value;
                    OnPropertyChanged("Code");
                }
            }
        }

        public string City
        {
            get { return model.City; }
            set
            {
                if (!model.City.Equals(value))
                {
                    model.City = value;
                    OnPropertyChanged("City");
                }
            }
        }

        //Er bundet til Datagrid.SelectedItem
        public Zipcode SelectedModel
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged("Code");
                OnPropertyChanged("City");
                OnPropertyChanged("SelectedModel");
            }
        }

        //private void Clear()
        //{
        //    //SelectedModel = null;
        //    model = new Zipcode();
        //    OnPropertyChanged("Code");
        //    OnPropertyChanged("City");
        //    OnPropertyChanged("SelectedModel");
        //}





    }
}

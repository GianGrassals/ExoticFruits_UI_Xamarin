using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ExoticFruits_UI
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private ObservableCollection<Fruits> Fruits;

        public ObservableCollection<Fruits> fruits
        {
            get { return Fruits; }
            set { Fruits = value ;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("fruits"));
                }

            }
         
         

        
        public MainViewModel()
        {
            fruits = new ObservableCollection<Fruits>();
         
            AddData();
        }


        private void AddData()
        {
            fruits.Add(new Fruits
            {
                id = 0,
                fruitName = "Durian Mon Tong",
                fruitPrice = "$19.99",
                imgSource = "durian.png",
                backgroundColor = "#f5e0bc"

            });
            fruits.Add(new Fruits
            {
                id = 1,
                fruitName = "Hawaiian Papaya",
                fruitPrice = "$4.55",
                imgSource = "papaya.png",
                backgroundColor = "#eb9d63"

            });
            fruits.Add(new Fruits
            {
                id = 1,
                fruitName = "Kiwi",
                fruitPrice = "$2.30",
                imgSource = "kiwi.png",
                backgroundColor = "#dbde6a"

            });
        }
    }
}

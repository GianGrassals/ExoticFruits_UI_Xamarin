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

        private ObservableCollection<Markets> Markets;

        public ObservableCollection<Markets> markets
        {
            get { return Markets; }
            set { Markets = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("markets"));
                }
        }



        public MainViewModel()
        {
            fruits = new ObservableCollection<Fruits>();
            markets = new ObservableCollection<Markets>();
         
            AddDataFruits();
            AddDataMarkets();
        }


        private void AddDataFruits()
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



        private void AddDataMarkets()
        {
            markets.Add(new Markets
            {
                id = 0,
                marketName = "Brooklyn Fruit Valley",
                marketSchedule = "09:00-21:00",
                imgSource = "market1.jpg",
                startsRate = 4.9,
                distance = "2 km"

            });
            markets.Add(new Markets
            {
                id = 1,
                marketName = "24/7 Fruit Market",
                marketSchedule = "00:00-24:00",
                imgSource = "market2.jpg",
                startsRate = 4.5,
                distance = "3 km"
                

            });
            markets.Add(new Markets
            {
                id = 2,
                marketName = "Exotic Fruits Market",
                marketSchedule = "00:00-24:00",
                imgSource = "market3.jpg",
                startsRate = 4.3,
                distance = "4 km"


            });

        }

    }
}

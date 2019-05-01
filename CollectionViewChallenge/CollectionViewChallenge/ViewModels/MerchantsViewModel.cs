using CollectionViewChallenge.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionViewChallenge.ViewModels
{
    public class MerchantsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        ObservableCollection<MerchantCategory> _merchantsCategory;
        public ObservableCollection<MerchantCategory> MerchantsCategory { get { return _merchantsCategory; } set { SetProperty(ref _merchantsCategory, value); } }

        public object SelectedItem
        {
            set
            {
                int x = 1;
            }
        }

        public MerchantsViewModel()
        {
            MerchantsCategory = MockData();
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }
            storage = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<MerchantCategory> MockData()
        {
            MerchantCategory sportCategory = new MerchantCategory() { Id = 1, Name = "sports" };
            Merchant football = new Merchant() { Id = 123, Name = "football", MerchantCategoryId = 1 };
            Merchant volleyball = new Merchant() { Id = 123, Name = "voleyball", MerchantCategoryId = 1 };
            Merchant handball = new Merchant() { Id = 123, Name = "handball", MerchantCategoryId = 1 };
            Merchant mountaining = new Merchant() { Id = 123, Name = "mountaining", MerchantCategoryId = 1 };
            Merchant swim = new Merchant() { Id = 123, Name = "swim", MerchantCategoryId = 1 };
            Merchant gym = new Merchant() { Id = 123, Name = "gym", MerchantCategoryId = 1 };
            sportCategory.Merchants = new List<Merchant>() { football, volleyball, handball, mountaining, swim, gym };


            MerchantCategory foodCategory = new MerchantCategory() { Id = 2, Name = "foods" };
            Merchant iranian = new Merchant() { Id = 123, Name = "iranian", MerchantCategoryId = 2 };
            Merchant halal = new Merchant() { Id = 123, Name = "halal", MerchantCategoryId = 2 };
            Merchant chiness = new Merchant() { Id = 123, Name = "chiness", MerchantCategoryId = 2 };
            Merchant italian = new Merchant() { Id = 123, Name = "italian", MerchantCategoryId = 2 };
            Merchant fastfood = new Merchant() { Id = 123, Name = "fastfood", MerchantCategoryId = 2 };
            foodCategory.Merchants = new List<Merchant>() { iranian, halal, chiness, italian, fastfood };


            MerchantCategory entertainment = new MerchantCategory() { Id = 3, Name = "entertainment" };
            Merchant bagJump = new Merchant() { Id = 123, Name = "bagJump", MerchantCategoryId = 3 };
            Merchant sorena = new Merchant() { Id = 123, Name = "sorena", MerchantCategoryId = 3 };
            Merchant abdo = new Merchant() { Id = 123, Name = "abdo", MerchantCategoryId = 3 };
            Merchant azadi = new Merchant() { Id = 123, Name = "azadi", MerchantCategoryId = 3 };
            Merchant chemidonam = new Merchant() { Id = 123, Name = "chemidonam", MerchantCategoryId = 3 };
            Merchant rostamDastan = new Merchant() { Id = 123, Name = "rostamDastan", MerchantCategoryId = 3 };
            Merchant vrKade = new Merchant() { Id = 123, Name = "vrKade", MerchantCategoryId = 3 };
            Merchant hormozDance = new Merchant() { Id = 123, Name = "hormozDance", MerchantCategoryId = 3 };
            Merchant esmFamil = new Merchant() { Id = 123, Name = "esmFamil", MerchantCategoryId = 3 };
            Merchant chobKhat = new Merchant() { Id = 123, Name = "chobKhat", MerchantCategoryId = 3 };
            Merchant dooz = new Merchant() { Id = 123, Name = "dooz", MerchantCategoryId = 3 };
            Merchant mench = new Merchant() { Id = 123, Name = "mench", MerchantCategoryId = 3 };
            Merchant shahin = new Merchant() { Id = 123, Name = "shahin", MerchantCategoryId = 3 };
            entertainment.Merchants = new List<Merchant>()
            {
                bagJump, sorena, abdo, azadi, chemidonam, rostamDastan, vrKade, hormozDance, esmFamil,
                chobKhat, dooz, mench, shahin
            };


            return new ObservableCollection<MerchantCategory>() { sportCategory, foodCategory, entertainment, sportCategory, foodCategory, entertainment };
        }
    }
}

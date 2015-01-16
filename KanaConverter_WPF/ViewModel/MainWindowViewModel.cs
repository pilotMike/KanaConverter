using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using KanaConverterLib;

namespace KanaConverter_WPF.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private RelayCommand _autoConvertCommand;
        private RelayCommand _hiraganaConvertCommand;
        private RelayCommand _katakanaConvertCommand;
        private string _outputText;

        public MainWindowViewModel()
        {
            InputText = "Enter Japanese or English characters here and click a button. sample text: nihon no sushi ha oishii desu ne!";
        }
        
        public string InputText { get; set; }

        public string OutputText
        {
            get { return _outputText; }
            set
            {
                _outputText = value;
                NotifyPropertyChanged("OutputText");
            }
        }

        public RelayCommand AutoConvertCommand
        {
            get
            {
                return _autoConvertCommand ??
                       (_autoConvertCommand = new RelayCommand(() =>
                       {
                           var converter = KanaConverter.GetConverter(InputText);
                           OutputText = converter.Convert(InputText);
                       }));
            }
            set { _autoConvertCommand = value; }
        }

        public RelayCommand HiraganaConvertCommand
        {
            get
            {
                return _hiraganaConvertCommand ??
                       (_hiraganaConvertCommand = new RelayCommand(() =>
                       {
                           var converter = KanaConverter.GetConverter(InputText, CharacterType.Hiragana);
                           OutputText = converter.Convert(InputText);
                       }));
            }
            set { _autoConvertCommand = value; }
        }

        public RelayCommand KatakanaConvertCommand
        {
            get
            {
                return _katakanaConvertCommand ??
                       (_katakanaConvertCommand = new RelayCommand(() =>
                       {
                           var converter = KanaConverter.GetConverter(InputText, CharacterType.Katakana);
                           OutputText = converter.Convert(InputText);
                       }));
            }
            set { _autoConvertCommand = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
    }
}

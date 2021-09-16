using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace Example.ViewModel
{
    public class MainViewModel : ViewModelBase {
        
        string savedText;
        
        public string Text {
            get => GetValue<string>();
            set {
                SetValue(value);
                RaisePropertyChanged(nameof(IsSaved));
            }
        }
        public bool IsSaved {
            get {
                return Text == savedText && !string.IsNullOrEmpty(Text);
            }
        }

        [Command]
        public void Save() {
            savedText = Text;
            RaisePropertyChanged(nameof(IsSaved));
        }
        
        [Command]
        public void Close() {
            savedText = string.Empty;
            Text = string.Empty;
        }
    }
}

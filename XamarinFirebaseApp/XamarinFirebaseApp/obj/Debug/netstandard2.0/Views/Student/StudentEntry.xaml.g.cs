//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("XamarinFirebaseApp.Views.Student.StudentEntry.xaml", "Views/Student/StudentEntry.xaml", typeof(global::XamarinFirebaseApp.Views.Student.StudentEntry))]

namespace XamarinFirebaseApp.Views.Student {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Student\\StudentEntry.xaml")]
    public partial class StudentEntry : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Entry TxtName;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Entry TxtEmail;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button ButtonSave;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(StudentEntry));
            TxtName = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "TxtName");
            TxtEmail = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "TxtEmail");
            ButtonSave = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "ButtonSave");
        }
    }
}
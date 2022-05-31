namespace MauiApp1;

public partial class NewPage1 : ContentPage {
    private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
	public NewPage1()
	{
		InitializeComponent();
        if (File.Exists(_fileName)) {
            editor.Text = File.ReadAllText(_fileName);
        }
    }

    private void OnSaveButtonClicked(object sender, EventArgs e) {
        throw new NotImplementedException();
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e) {
        throw new NotImplementedException();
    }
}
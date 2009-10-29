// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Refactoring.Rename {
    
    public partial class RenameItemDialog {
        
        private Gtk.VBox vbox;
        
        private Gtk.HBox hbox;
        
        private Gtk.Label labelNewName;
        
        private Gtk.Entry entry;
        
        private Gtk.CheckButton renameFileFlag;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Image imageWarning;
        
        private Gtk.Label labelWarning;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonPreview;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Refactoring.Rename.RenameItemDialog
            this.Name = "MonoDevelop.Refactoring.Rename.RenameItemDialog";
            this.Title = Mono.Unix.Catalog.GetString("Rename {0}");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child MonoDevelop.Refactoring.Rename.RenameItemDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox = new Gtk.VBox();
            this.vbox.Name = "vbox";
            this.vbox.Spacing = 6;
            this.vbox.BorderWidth = ((uint)(6));
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox = new Gtk.HBox();
            this.hbox.Name = "hbox";
            this.hbox.Spacing = 6;
            // Container child hbox.Gtk.Box+BoxChild
            this.labelNewName = new Gtk.Label();
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.LabelProp = Mono.Unix.Catalog.GetString("New na_me:");
            this.labelNewName.UseUnderline = true;
            this.hbox.Add(this.labelNewName);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox[this.labelNewName]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox.Gtk.Box+BoxChild
            this.entry = new Gtk.Entry();
            this.entry.CanFocus = true;
            this.entry.Name = "entry";
            this.entry.IsEditable = true;
            this.entry.InvisibleChar = '●';
            this.hbox.Add(this.entry);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox[this.entry]));
            w3.Position = 1;
            this.vbox.Add(this.hbox);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.renameFileFlag = new Gtk.CheckButton();
            this.renameFileFlag.CanFocus = true;
            this.renameFileFlag.Name = "renameFileFlag";
            this.renameFileFlag.Label = Mono.Unix.Catalog.GetString("Rename file that contains public class");
            this.renameFileFlag.Active = true;
            this.renameFileFlag.DrawIndicator = true;
            this.renameFileFlag.UseUnderline = true;
            this.vbox.Add(this.renameFileFlag);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox[this.renameFileFlag]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.imageWarning = new Gtk.Image();
            this.imageWarning.Name = "imageWarning";
            this.imageWarning.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-apply", Gtk.IconSize.Button, 20);
            this.hbox1.Add(this.imageWarning);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.imageWarning]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.labelWarning = new Gtk.Label();
            this.labelWarning.Name = "labelWarning";
            this.hbox1.Add(this.labelWarning);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox1[this.labelWarning]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox.Add(this.hbox1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox[this.hbox1]));
            w8.Position = 2;
            w8.Expand = false;
            w8.Fill = false;
            w1.Add(this.vbox);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.vbox]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Internal child MonoDevelop.Refactoring.Rename.RenameItemDialog.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Name = "dialog1_ActionArea";
            w10.Spacing = 10;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonCancel]));
            w11.Expand = false;
            w11.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonPreview = new Gtk.Button();
            this.buttonPreview.CanFocus = true;
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.UseUnderline = true;
            this.buttonPreview.Label = Mono.Unix.Catalog.GetString("_Preview");
            this.AddActionWidget(this.buttonPreview, 0);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonPreview]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonOk]));
            w13.Position = 2;
            w13.Expand = false;
            w13.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 365;
            this.DefaultHeight = 154;
            this.labelNewName.MnemonicWidget = this.entry;
            this.renameFileFlag.Hide();
            this.Show();
        }
    }
}

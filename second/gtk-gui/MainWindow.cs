
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed2;

	private global::Gtk.Label label1;

	private global::Gtk.Entry entry1;

	private global::Gtk.Label label2;

	private global::Gtk.Entry entry2;

	private global::Gtk.Button button1;

	private global::Gtk.Label label3;

	private global::Gtk.Label label4;

	private global::Gtk.Entry entry3;

	private global::Gtk.Button button2;

	private global::Gtk.Entry entry4;

	private global::Gtk.Label lblTimer;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(6));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed2 = new global::Gtk.Fixed();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("getal 1:");
		this.fixed2.Add(this.label1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label1]));
		w1.X = 115;
		w1.Y = 122;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.fixed2.Add(this.entry1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.entry1]));
		w2.X = 234;
		w2.Y = 116;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("getal 2:");
		this.fixed2.Add(this.label2);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label2]));
		w3.X = 115;
		w3.Y = 168;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '●';
		this.fixed2.Add(this.entry2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.entry2]));
		w4.X = 237;
		w4.Y = 162;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Events = ((global::Gdk.EventMask)(512));
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("som");
		this.fixed2.Add(this.button1);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button1]));
		w5.X = 127;
		w5.Y = 229;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("                  ");
		this.fixed2.Add(this.label3);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label3]));
		w6.X = 245;
		w6.Y = 243;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("name:");
		this.fixed2.Add(this.label4);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label4]));
		w7.X = 115;
		w7.Y = 75;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.entry3 = new global::Gtk.Entry();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '●';
		this.fixed2.Add(this.entry3);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.entry3]));
		w8.X = 239;
		w8.Y = 76;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Test Async");
		this.fixed2.Add(this.button2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button2]));
		w9.X = 176;
		w9.Y = 17;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.entry4 = new global::Gtk.Entry();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '●';
		this.fixed2.Add(this.entry4);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.entry4]));
		w10.X = 258;
		w10.Y = 26;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.lblTimer = new global::Gtk.Label();
		this.lblTimer.Name = "lblTimer";
		this.lblTimer.LabelProp = global::Mono.Unix.Catalog.GetString("lblTimer");
		this.fixed2.Add(this.lblTimer);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.lblTimer]));
		w11.X = 18;
		w11.Y = 30;
		this.Add(this.fixed2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 479;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
	}
}
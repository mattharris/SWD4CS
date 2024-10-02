# SWD4CS
 * SWD4CS, or Simple WinForms Designer for CSharp (VSCode)
 * VisualStudio is heavy, so I often use VSCode. But it doesn't have a designer.
 * I had no idea how to make a designer, so I wrote one as I thought of it.
 * It's not possible to make anything complicated with this method. Maybe it'll be usable for a simple tool?
  
## Development environment
 * Windows11 Home  
 * VisualStudio2022 C# → VSCode .net6.0
 
## Screenshots
![SWD4CS](https://user-images.githubusercontent.com/86605611/152679486-e8f7bbed-69b4-4186-b402-35d7bd2fec8f.png)
![SWD4CS](https://user-images.githubusercontent.com/86605611/152784518-c135ec3a-e156-4163-8f8d-90cc023d8448.png)
* Control Tree is display only


## Videos
 https://youtu.be/BJAhuU2W3uM  
 https://youtu.be/3LyjAvXLpYg  
 https://youtu.be/82qa0vOP_qk  
 https://youtu.be/FkDaMW4hGyk
 
## Blog
 https://danpapa-hry.hateblo.jp/entry/2022/02/23/210416
 
## Implementation
 ・ポトペタ  
 ・一部のプロパティ変更  
 ・Button  
 ・CheckBox  
 ・CheckedListBox  
 ・ComboBox  
 ・DataGridView  
 ・DateTimePicker  
 ・DomainUpDown  
 ・FlowLayoutPanel  
 ・GroupBox  
 ・HScrollBar  
 ・Label  
 ・LinkLabel  
 ・ListBox  
 ・ListView  
 ・MaskedTextBox  
 ・MonthCalender  
 ・Panel  
 ・PictureBox  
 ・ProgressBar  
 ・PropertyGrid  
 ・RadioButton  
 ・RichTextBox  
 ・SplitContainer  
 ・Splitter  
 ・StatusStrip  
 ・TabControl  
 ・TableLayoutPanel  
 ・TabPage  
 ・TextBox  
 ・TrackBar  
 ・TreeView  
 ・VScrollBar  
 ・ColorDialog  
 ・FolderBrowserDialog  
 ・FontDialog  
 ・imageList  
 ・OpenFiledialog  
 ・SaveFiledialog  
 ・Timer  
 ・Designer.csファイルのRead/Write　~~（ただし、SWD4CS以外で編集したものは開けない）~~  
 ・他のコントローラー等は必要になったら追加する。

## 対応プロパティ（Type）
 ・System.Drawing.Point  
 ・System.Drawing.Size  
 ・System.String  
 ・System.Boolean  
 ・System.Int32  
 ・System.Windows.Forms.AnchorStyles  
 ・System.Windows.Forms.DockStyle  
 ・System.Drawing.ContentAlignment  
 ・System.Windows.Forms.ScrollBars  
 ・System.Windows.Forms.HorizontalAlignment  
 ・System.Drawing.Color  
 ・System.Windows.Forms.FormStartPosition  
 ・System.Windows.Forms.FormWindowState  
 ・System.Windows.Forms.FixedPanel  
 ・System.Windows.Forms.PictureBoxSizeMode  
 ・System.Windows.Forms.View  
 ・System.Windows.Forms.Orientation  
 ・System.Windows.Forms.FormBorderStyle  
 ・System.Windows.Forms.AutoScaleMode  
 ・System.Drawing.Font  
 ・System.Windows.Forms.TableLayoutPanelCellBorderStyle  

## コントロール追加方法  
 * 「// コントロール追加時に下記を編集すること」に追記  
・cls_control.cs  

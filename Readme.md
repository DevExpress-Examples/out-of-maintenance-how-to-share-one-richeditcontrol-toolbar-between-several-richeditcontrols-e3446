# How to share one RichEditControl toolbar between several RichEditControls


<p>Let us assume that we have created a simple rich text editor with a toolbar interface (see <a href="http://documentation.devexpress.com/#WPF/CustomDocument8847"><u>Lesson 2 - Provide Bars UI for a RichEditControl</u></a> and <a href="http://documentation.devexpress.com/#WPF/CustomDocument8853"><u>Lesson 3 - Provide Ribbon UI for a RichEditControl</u></a> ). If you wish to reuse RichEditControl UI for several RichEditControls on the page, execute the following steps:</p><p>1) Define a special <strong>RichEditControlProvider</strong> in xaml and change bindings of all toolbar items as follows:</p><p>RichEditControl="{Binding ElementName=richEditControl1}"    ->    RichEditControl="{Binding Path=RichEditControl, ElementName=richEditControlProvider1}"</p><p>This will point toolbar items to an intermediate component instead of a particular RichEditControl instance.</p><p>2) Remove binding to the BarManager component (it is defined for the <strong>RichEditControl.BarManager</strong> property):</p><p>BarManager="{Binding ElementName=barManager1, Mode=OneTime}"</p><p>3) Handle the <strong>RichEditControl.GotFocus</strong> event for all RichEditControls on the page to assign BarManager to the current RichEditControl and assign this RichEditControl to the <strong>RichEditBarController.RichEditControl</strong> property.</p>

<br/>



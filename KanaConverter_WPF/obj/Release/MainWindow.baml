   M S B A M L   `   `   `  ���� L  HKanaConverter_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:KanaConverter_WPF.ViewModelKanaConverter_WPF.ViewModel  "    KanaConverter_WPF.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     8vm)clr-namespace:KanaConverter_WPF.ViewModel       � Title$  
MainWindow��$	��350��$	��525�� � DataContext 5   /KanaConverter_WPF.ViewModel.MainWindowViewModel   � 	Resources  �� 
TargetType   ButtonStyle �� Property �� Value��%,   &	        �� " ��.���  � ��$ 6q�.���  � RowDefinitions �� $
��auto ��� $
��1.5* ��� $
��auto ��� .+��� $
��Wrap=�$����The goal of this project is to allow the conversion between Japanese and Roman letters in addition to the conversion between Hiragana and Katakana. However, the way the tool is currently set up, it will not allow the input of hiragana text to be converted to hiragana text. It also does not automatically remove spaces, as I have yet to determine whether it should be included or not.���� $��1�� �� TextWrapping$
 Wrap=����� *	InputText+ �� Mode$ TwoWay=��� $��2��$��Right=�	 �� Orientation$	 
Horizontal=�.+��� $��convert auto��#��[  ���� *AutoConvertCommand+�� $��convert hiragana��#��[  ���� *HiraganaConvertCommand+�� $��convert katakana��#��[  ���� *KatakanaConvertCommand+�� $��3��
 �� 
IsReadOnly
 . $
 Wrap=����� *
OutputText+
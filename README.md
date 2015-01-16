# KanaConverter
**To run the app, run KanaConverter_WPF exe.

The goal of this project is to allow the conversion between Japanese and Roman 
letters in addition to the conversion between Hiragana and Katakana. It 
appears to be appropriately functional.

The solution is divided between the WPF app, Test project, and the library that
holds the converter classes.

The KanaConverter class is an abstract base class, with other classes handling the
conversion, which inherit from IKanaConverter. The KanaConverter class has static methods 
for determining the type of text and for getting a converter. If a conversion destination
is not provided, it will assume Hiragana<->Romaji. For usages, see the test project's
test classes.

#Notes about the converter
The way the tool is currently set up, it will not allow the input of hiragana 
text to be converted to hiragana text. It also does not automatically remove 
spaces, as I have yet to determine whether it should be included or not.

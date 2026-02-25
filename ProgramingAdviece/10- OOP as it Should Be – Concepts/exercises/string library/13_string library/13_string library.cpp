
#include <iostream>
#include"clsString.h";
int main()
{
    clsString str1;
    str1.value = "hossam alsid gholam";
    clsString str2("ali");

    cout << "the second name is :" << str2.value << endl;
    cout << "the frist name is :" << str1.getValue() << endl;

    cout << "frist char in each word\n";
    clsString::fristChar("alie mohamed gholam"); cout << endl;
    str1.fristChar();

    cout << "\n\n\nupper frist char in each word\n";
    cout << clsString::uperFristLitterOfEachWord("alie mohamed gholam"); cout << endl;
    str1.uperFristLitterOfEachWord();
    cout << str1.value;

    cout << "\n\n\nlowerr frist char in each word\n";
    cout << clsString::lowerFristLitterOfEachword("alie mohamed gholam"); cout << endl;
    str1.lowerFristLitterOfEachword();
    cout << str1.value;

    cout << "\n\n\n upper all string\n";
    cout << clsString::upperAllString("alie mohamed gholam"); cout << endl;
    str1.upperAllString();
    cout << str1.value;

    cout << "\n\n\nlowerr all string\n";
    cout << clsString::lowerAllString("alie mohamed gholam"); cout << endl;
    str1.lowerAllString();
    cout << str1.value;

    cout << "\n\n\ninvertt all string\n";
    cout << clsString::invertAllLetterCase("alie mohamed gholam"); cout << endl;
    str1.invertAllLetterCase();
    cout << str1.value;

    cout << "\n\n\ncount capital litter \n";
    cout << clsString::countCapitalLitter("alie mohamed gholam"); cout << endl;
    cout << str1.countCapitalLitter();


    cout << "\n\n\ncount small litter \n";
    cout << clsString::countSmallLitter("alie mohamed gholam"); cout << endl;
    cout << str1.countSmallLitter();


    cout << "\n\n\ncount specific litter \n";
    cout << clsString::countSpecificLetter("alie mohamed gholam", 'a', false); cout << endl;
    cout << str1.countSpecificLetter('h', false);

    cout << "\n\n\ncount vowels litter \n";
    cout << clsString::countVowels("alie mohamed gholam"); cout << endl;
    cout << str1.countVowels();

    cout << "\n\n\ncount wordes  \n";
    cout << clsString::countWords("alie mohamed gholam"); cout << endl;
    cout << str1.countWords();


    cout << "\n\n\nsplit string\n";
    vector<string> frist = clsString::split("alie mohamed gholam", " ");
    for (const string& i : frist) {
        cout << i << "\n";
    }
    cout << endl;
    vector<string>seconde = str1.split(" ");
    vector<string>::iterator item;
    for (item = seconde.begin(); item <seconde.end(); item++) {
        cout << *item << "\n";
    }

    cout << "\n\n\n replace word\n";
    cout<<clsString::replaceWorde("alie mohamed gholam", "alie", "osame", false);
    cout << endl;
    str1.replaceWorde("hossam", "king", false);
    cout << str1.value;


    cout << "\n\n\nremove punctioin\n";
    cout << clsString::removePunction("alie mohamed gholam"); cout << endl;
    str1.removePunction();
    cout << str1.value;
   //reversword
}


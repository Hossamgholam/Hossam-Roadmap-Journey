#include<iostream>
#include<vector>
#include<string>
using namespace std;

/*
read word;
split words
print vector
*/
string read_string(){
    string worde;
    cout<<"pleseas inter your word:";getline(cin,worde);
    return worde;
}

vector<string> split_words(string your_word,string your_delimeter){
    short pos=0;
    string word="";
    vector<string>storge;
    while((pos=your_word.find(your_delimeter))!=std::string::npos){
        word=your_word.substr(0,pos);
        if(word!=""){
            storge.push_back(word);
        }
        your_word.erase(0,pos+your_delimeter.length());
    }
    if(your_word!=""){
        storge.push_back(your_word);
    }
    return storge;
}
void split_words(string your_word,string your_array[100],int &size,string your_delimeter){
    short pos=0;
    string word="";
    size=0;
    while((pos=your_word.find(your_delimeter))!=std::string::npos){
        word=your_word.substr(0,pos);
        if(word!=""){
            your_array[size]=word;
            size++;
        }
        your_word.erase(0,pos+your_delimeter.length());
    }
    if(your_word!=""){
        your_array[size]=your_word;
        size++;
    }
    
}

 string revers_vector(vector<string> your_storge){
   // for(string &i: your_storge){
    //    cout<<i<<endl;
    //}

   // for(int i=your_storge.size()-1;i>=0;i--){
   //     cout<<your_storge[i]<<endl;
   // }
   string a="";
    vector<string>::iterator item;
    for(item=your_storge.end()-1;item>=your_storge.begin();--item){
       a=a+*item+" ";
    }
    return a.substr(0,a.length()-1);
}

void print_array(string your_array[100],int size){
    for(int i=size-1;i>=0;i--){
        cout<<your_array[i]<<endl;
    }
}
int main(){
    vector<string> storge= split_words(read_string()," ");
    cout<<"the word after revers is :"<<revers_vector(storge);

   // string array[100];
   // int size=0;
   // split_words(read_string(),array,size," ");
   // print_array(array,size);
    
}
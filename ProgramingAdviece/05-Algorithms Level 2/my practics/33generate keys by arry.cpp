#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;
enum en_random_type{small_letter=1,capital_leatter=2,special_character=3,digit=4};
int read_number(string message){
    int your_number;
    do{
        cout<<message;
        cin>>your_number;
    }while(your_number<0);
    return your_number;
}
int randomvarible(int your_from,int your_to){
    int random=rand()%(your_to-your_from+1)+your_from;
    return random;
}

char random_all(en_random_type your_type ){
    char random;
    if(your_type==en_random_type::small_letter){
        random=randomvarible(97,122);
    }
    else if(your_type==en_random_type::capital_leatter){
        random=randomvarible(65,90);
    }
    else if(your_type==en_random_type::special_character){
        random=randomvarible(32,47);
    }
    else{
        random=randomvarible(48,57);
    }
    return char(random);
}
string genarate_word(en_random_type your_type,int your_length){
    string worde="";
    for(int i=0;i<your_length;i++){
        worde=worde+random_all(your_type);
    }
    return worde;
}

string genarate_key(){
    string key="";
    key=key+genarate_word(en_random_type::capital_leatter,4)+"-";
    key=key+genarate_word(en_random_type::capital_leatter,4)+"-";
    key=key+genarate_word(en_random_type::capital_leatter,4)+"-";
    key=key+genarate_word(en_random_type::capital_leatter,4);

    return key;
}




void genarate_number_key(string your_arry[100],int your_number){
    for(int i=0;i<your_number;i++){
       your_arry[i]=genarate_key();
    }
}

void print_arry(string your_arry[100],int your_size){
    for(int i=0;i<your_size;i++){
        cout<<"element["<<i+1<<"]="<<your_arry[i]<<"\n";
    }
    cout<<endl;
}
int main(){
    srand(time(0));
    int size=read_number("please inter your number:");
    string arry_data[100];
    genarate_number_key(arry_data,size);
    print_arry(arry_data,size);
}
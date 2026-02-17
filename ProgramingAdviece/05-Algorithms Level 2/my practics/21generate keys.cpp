#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;
enum en_random_type{small_letter=1,capital_leatter=2,special_character=3,digit=4};
int read_number(string message){
    int your_number;
    do{
        cout<<message; cin>>your_number;
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


/*void genarate_key(){
    for(int i=0;i<4;i++){
        for(int y=0;y<4;y++){
            cout<<random_all(en_random_type::capital_leatter);
        }
        if(i<3){
             cout<<"-";
        }
    }
}*/

void genarate_number_key(int your_number){
    for(int i=0;i<your_number;i++){
        cout<<"key["<<i+1<<"]:"<<genarate_key()<<"\n";
    }
}

int main(){
    srand(time(0));
    genarate_number_key(read_number("please inter your number:"));

}
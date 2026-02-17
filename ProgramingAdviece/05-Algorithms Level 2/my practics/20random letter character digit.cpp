#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;
enum en_random_type{small_letter=1,capital_leatter=2,special_character=3,digit=4};
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
int main(){
    srand(time(0));
    cout<<random_all(en_random_type::small_letter)<<endl;
    cout<<random_all(en_random_type::capital_leatter)<<endl;
    cout<<random_all(en_random_type::special_character)<<endl;
    cout<<random_all(en_random_type::digit)<<endl;
}
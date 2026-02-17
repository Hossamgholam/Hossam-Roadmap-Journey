#include<iostream>
using namespace std;
short read_age(){
    short age;
    cout<<"plese inter your age:";cin>>age;
    return age;
}
bool valid_age(short your_age,short your_from,short your_to){
    if(your_age>=your_from&&your_age<=your_to){
        return true;
    }
    else{
        return false;
    }
}
void print_result(short age){
    if(valid_age(age,18,45)){
        cout<<age<<"  is avilde\n";
    }
    else{
        cout<<age <<" is not avilde\n";

        }
}

int read_until_age_between(short your_from,short your_to){
    short age=0;
    do{
       age= read_age();
    }while(!valid_age(age,18,45));
}
int main(){
    print_result(read_until_age_between(18,45));

}
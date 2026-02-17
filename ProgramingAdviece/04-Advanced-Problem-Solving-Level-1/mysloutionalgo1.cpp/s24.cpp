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
    else{cout<<age <<" is not avilde\n";}
}

int main(){
    print_result(read_age());

}
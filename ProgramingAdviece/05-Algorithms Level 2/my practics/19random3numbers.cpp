#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;
int randomvarible(int your_from,int your_to){
    int random=rand()%(your_to-your_from+1)+your_from;
    return random;
}
int main(){
   srand(time(0));
    cout<<randomvarible(20,50)<<endl;
    cout<<randomvarible(20,50)<<endl;
    cout<<randomvarible(20,50)<<endl;

    
}
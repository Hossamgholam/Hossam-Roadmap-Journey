#include<iostream>
using namespace std;

void readarrydata(int yourarry[3]){
    cout<<"please inter your frist number:";cin>>yourarry[0];
    cout<<"please inter your frist number:";cin>>yourarry[1];
    cout<<"please inter your frist number:";cin>>yourarry[2];

}
void wrritearrydata(int yourarry[3]){
    cout<<" your frist number :"<<yourarry[0]<<"\n";
    cout<<" your second number:"<<yourarry[1]<<"\n";
    cout<<" your threed number:"<<yourarry[2]<<endl;

}

int main(){
    int arrydata[3];

    readarrydata(arrydata);
    wrritearrydata(arrydata);

}
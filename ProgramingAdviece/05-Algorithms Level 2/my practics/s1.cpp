#include<iostream>
using namespace std;
void print_row(){
    cout<<"\n\n\t\t\t multiblication table\t\t\t\n\n";
    for(int i=1;i<=10;i++){
        cout<<"\t"<<i;
    }
    cout<<"\n";
    cout<<"______________________________________________________________________________________\n";
}
string columsperator(int i){
    if(i<10){
        return "    |";
    }
    else{
        return "   |";
    }
}
void print_result(){
    print_row();
    for(int i=1;i<=10;i++){
        cout<<" "<<i<<columsperator(i)<<"\t";
        for(int y=1;y<=10;y++){
            cout<<i*y<<"\t";
        }
        cout<<endl;
    }
    
}
int main(){
    
     print_result();
}
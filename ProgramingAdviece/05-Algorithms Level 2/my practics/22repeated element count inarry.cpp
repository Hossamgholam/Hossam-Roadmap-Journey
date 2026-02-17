#include<iostream>
using namespace std;
int read_number(string message){
    int your_number;
    do{
        cout<<message; cin>>your_number;
    }while(your_number<0);
    return your_number;
}

void read_arry(int your_arry[100],int& your_size){
    cout<<"please inter your size:";cin>>your_size;

     cout<<"enter arry element:\n";
    for(int i=0;i<your_size;i++){
        cout<<"element["<<i+1<<"]:";cin>>your_arry[i];
    }
}
void print_arry(int your_arry[100],int your_size){
    for(int i=0;i<your_size;i++){
        cout<<your_arry[i]<<" ";
    }
    cout<<"\n";
}

int number_repeat(int your_arry[100],int your_size,int your_number_serche){
    int counter=0;
    for(int i=0;i<your_size;i++){
        if(your_number_serche==your_arry[i]){
            counter++;
        }
    }
    return counter;
}

int main(){
    int arry_data[100],size,number_serche;

    
    read_arry(arry_data,size);

    number_serche=read_number("please inter number you want to searche:");

    cout<<"orginal arry:";
    print_arry(arry_data,size);

    cout<<number_serche<<" is repeated "<<number_repeat(arry_data,size,number_serche);


}
#include<iostream>
#include<ctime>
#include<iomanip>
using namespace std;
/*
random function
full matrix
print matirx
*/

int random_number(int your_from,int your_to){
    return rand()%(your_to-your_from+1)+your_from;
}

void full_matrix(int your_matrix[3][3],int your_row,int your_colum){
    for(int i=0;i<3;i++){
        for(int y=0;y<3;y++){
            your_matrix[i][y]=random_number(1,100);
        }
    }
}
void print_matrix(int your_matrix[3][3],int your_row,int your_colum){
    for(int i=0;i<3;i++){
        for(int y=0;y<3;y++){
            cout<<setw(3)<<your_matrix[i][y]<<"\t";
        }
        cout<<endl;
    }
}

int main(){
    srand(time(0));
    int arrya_data[3][3]={};
    full_matrix(arrya_data,3,3);
    cout<<"the following is a 3x3 random matix:\n";
    print_matrix(arrya_data,3,3);

}

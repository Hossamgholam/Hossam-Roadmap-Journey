#include<iostream>
#include<ctime>
#include<iomanip>
using namespace std;
/*
random 
full_matrix
order_matrix
*/

void full_matrix(int your_matrix[3][3],int row ,int colum){
    int counter=1;
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_matrix[i][y]=counter;
            counter++;
        }
    }
}

void print_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
           cout<<setw(3)<<your_matrix[i][y]<<"\t";
        }
        cout<<endl;
    }
}


int main(){
    int matrix[3][3];
    full_matrix(matrix,3,3);
    cout<<"the matrix withe order number\n";
    print_matrix(matrix,3,3);

}
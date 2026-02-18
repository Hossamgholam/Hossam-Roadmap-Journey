#include<iostream>
#include<ctime>
#include<iomanip>
using namespace std;
/*

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
void temp(int &number1,int &number2){
    int temp=number1;
    number1=number2;
    number2=temp;

}
void transpose_matrix(int your_matrix[3][3],int row,int colum){
    for(int i=0;i<row;i++){
        for(int y=i;y<colum;y++){
            temp(your_matrix[i][y],your_matrix[y][i]);
        }
    }
}

void transpose_matrix(int your_matrix[3][3],int your_transpose[3][3],int row,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_transpose[y][i]=your_matrix[i][y];
        }
    }
}

int main(){
    int matrix[3][3];
    int transpose[3][3]={};
    full_matrix(matrix,3,3);

    cout<<"the matrix withe order number\n";
    print_matrix(matrix,3,3);

    transpose_matrix(matrix,3,3);
    cout<<"the matrix after transpose \n";
    print_matrix(matrix,3,3);

    transpose_matrix(matrix,transpose,3,3);
    cout<<"the matrix after transpose \n";
    print_matrix(transpose,3,3);
   

}
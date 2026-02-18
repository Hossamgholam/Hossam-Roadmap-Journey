#include<iostream>
#include<ctime>
#include<iomanip>
using namespace std;

/*
random 
full matrix
print matrix
sum each row
*/
int random_number(int your_from,int your_to){
    return rand()%(your_to-your_from+1)+your_from;
}
void full_matrix(int your_matrix[3][3],int row,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_matrix[i][y]=random_number(1,100);
        }
    }
}
void print_matrix(int your_matrix[3][3],int row,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
           cout<<setw(3) <<your_matrix[i][y]<<"\t";
        }
        cout<<endl;
    }
}
int sum_row(int your_matrix[3][3],int number_row,int colum){
    int sum=0;
    for(int y=0;y<colum;y++ ){
        sum+=your_matrix[number_row][y];
    }
    return sum;
}
void print_each_row(int your_matrix[3][3],int row,int colum){
    for(int i=0;i<row;i++){
        cout<<"row["<<i+1<<"] sum = "<<sum_row(your_matrix,i,colum)<<endl;
    }
}
int main(){
  srand(time(0));
  int matrix[3][3];
  full_matrix(matrix,3,3);
  cout<<"the following is a 3x3 random matrix:\n";
  print_matrix(matrix,3,3);

  cout<<"the folowing are the sum of each row in the matrix:\n";
  print_each_row(matrix,3,3);
}
#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number 
full matrix
print matrix;
full sum colm in arry
print arry
*/
int random_number(int your_from,int your_to){
    return rand()%(your_to-your_from+1)+your_from;
}
void full_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_matrix[i][y]=random_number(1,100);
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
int sum_colum(int your_matrix[3][3],int row,int number_colum){
    int sum=0;
    for(int i=0;i<row;i++){
        sum+=your_matrix[i][number_colum];
    }
    return sum;
}
void storage_sum_colom(int your_matrix[3][3],int row,int colum,int your_array[3]){
    for(int i=0;i<colum;i++){
        your_array[i]=sum_colum(your_matrix, row,i);
    }
}
void print_array(int your_array[3],int size){
    for(int i=0;i<size;i++){
        cout<<"row ["<<i+1<<"] = "<<your_array[i]<<endl;
    }
}
int main(){
    srand(time(0));
      int matrix[3][3];int array[3];
  full_matrix(matrix,3,3);
  cout<<"the following is a 3x3 random matrix:\n";
  print_matrix(matrix,3,3);

  storage_sum_colom(matrix,3,3,array);
  cout<<"the folowing are the sum of each row in the matrix:\n";
  print_array(array,3);
}
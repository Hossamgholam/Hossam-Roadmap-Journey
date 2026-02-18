#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
equal matrix

*/
int random_number(int your_from,int your_to){
    return rand()%(your_to-your_from+1)+your_from;
}
void full_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_matrix[i][y]=random_number(1,10);
        }
    }
}

void print_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
        
            printf("%0*d\t",2,your_matrix[i][y]);
        }
        cout<<endl;
    }
}
int sum_matrix(int your_matrix[3][3],int row ,int colum){
    int sum=0;
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            sum+=your_matrix[i][y];
        }
    }
    return sum;
}

bool is_equal_matrixs(int your_matrix1[3][3],int your_matrix2[3][3],int row ,int colum){
  return (sum_matrix(your_matrix1,row,colum)==sum_matrix(your_matrix2,row,colum));
   

}

int main(){
    srand(time(0));
    int matirx1[3][3];int matrix2[3][3];
    cout<<"this is matrix1\n";
    full_matrix(matirx1,3,3);
    print_matrix(matirx1,3,3);

    cout<<"this is matrix2\n";
    full_matrix(matrix2,3,3);
    print_matrix(matrix2,3,3);

   if(is_equal_matrixs(matirx1,matrix2,3,3)){
    cout<<"the two matrix is equel\n";
  }
  else{
    cout<<"the tow matrix is not equal\n";
  }


}

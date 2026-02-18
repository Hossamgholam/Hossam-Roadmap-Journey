#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
typicla matrix

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
bool typical_matrix(int your_matrix[3][3],int my_matrix[3][3],int row,int colum){
    
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            if(your_matrix[i][y]!=my_matrix[i][y]){
                return false;
                
            }
        }
    }
    return true;
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

    if(typical_matrix(matirx1,matrix2,3,3)){
    cout<<"the two matrix is equel\n";
  }
  else{
    cout<<"the tow matrix is not equal\n";
  }

}

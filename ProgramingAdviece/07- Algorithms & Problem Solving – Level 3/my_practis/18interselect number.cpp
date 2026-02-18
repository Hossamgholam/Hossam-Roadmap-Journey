#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
interselect matrix

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
bool exists(int your_matrix[3][3],int row,int colum,int number){
    
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            if(your_matrix[i][y]==number){
                return true;
            }
        }
    }
    return false;
}
void interselect(int your_matrix[3][3],int my_matrix[3][3],int row,int colum){
    for(int i=0;i<row;i++){
        for(int j=0;j<colum;j++){
           if(exists(my_matrix,3,3,your_matrix[i][j])){
            printf("%0*d\t",2,your_matrix[i][j]);
           }
        }
    }
}
int main(){
     srand(time(0));
    int matrix1[3][3];int matrix2[3][3];
    cout<<"this is matrix1\n";
    full_matrix(matrix1,3,3);
    print_matrix(matrix1,3,3);

    cout<<"this is matrix2\n";
    full_matrix(matrix2,3,3);
    print_matrix(matrix2,3,3);

    cout<<"the interselect numbear\n";
    interselect(matrix1,matrix2,3,3);

}
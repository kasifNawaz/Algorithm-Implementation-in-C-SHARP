using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KMorrris
{
    class Program
    {
      public int kmpsearch(char []text, int n, char []pat, int  m) 
      {

{

int j, k, resume;

int next[250];


pat[m+1];

initnext( pat, m+1, next ); 

resume = next[m+1];

j = k = 1;

do {                        

if( j==0 || text[k]==pat[j] )

{

k++; j++;

}

else j = next[j];

if( j > m )

{

Report_match_at_position( k-m );

J = resume;

}

} while( k <= n );

pat[m+1] = END_OF_STRING;

}










       public int  initnext( int []pat,int m,int [] next ) 
       {

char pat[];

int m, next[];

{

int i, j;


i = 1; j = next[1] = 0;

do

{

if( j == 0 || pat[i] == pat[j] )

{

i++; j++;

if( pat[i] != pat[j] )  next[i] = j;

else                    next[i] = next[j];

}

else j = next[j];

}

while( i <= m ) ;

}
}
        static void Main(string[] args)
        {
        }
    }
}

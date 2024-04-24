using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public class CustomList<Type>: IEnumerable, IEnumerator
    {
        private int _count=0;
        private int _capacity=4;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        Type[] List;
        
        public Type this[int index]{
            get {return List[index];}
            set {List[index]=value;}
        }

        
        public CustomList(){

            List=new Type[_capacity];

        }
        public CustomList(int size){

            _capacity=size;
            List=new Type[_capacity];

        }
        public void Add(Type value){

            if(_count==_capacity){
                Grow();
            }
            List[_count++]=value;
            
        }
        void Grow(){
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            int increase=0;
            foreach(Type i in List){
                temp[increase++]=i;
            }
            List=temp;
        }
        public void AddRange(CustomList<Type> arr){
            for(int i=0;i<arr._count;i++){
                 if(_count==_capacity){
                Grow();}
                List[_count++]=arr[i];
            }
        }
        public bool Contains(Type value){
           foreach(Type i in List){
            if(i.Equals(value)){
                return true;
            }
           }
           return false;
        }
         public int IndexOf(Type value){
           int count=0;
           foreach(Type i in List){
            
            if(i.Equals(value)){
                return count;
            }
            count++;
           }
           return -1;
        }
        public void Insert(int index,Type value){
            _count++;
            for(int i=_count;i>=index;i--){
                if(i==index){
                    List[i]=value;
                    break;
                }
                if(_count==_capacity){
                Grow();
                }
                List[i]=List[i-1];

            }
        }
        public void RemoveAt(int index){
            _count--;
            for(int i=index;i<_count;i++){
                List[i]=List[i+1];
            }
        }
        public bool Remove(Type value){
            // _count--;
            if(IndexOf(value)>=0){
                RemoveAt(IndexOf(value));
                return true;
            }
            return false;
        }

        public void Reverse(){

            Type[] temp=new Type[_capacity];
            int c=0;
            for(int i=_count-1;i>=0;i--){
                temp[c++]=List[i];
            }
            List=temp;

        }
        int position=-1;
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {   if(position<_count-1){
            position++;
            return true;
        }
            Reset();
            return false;
        }

        public void Reset()
        {
            position=-1;
        }
        public object Current{get {return List[position];}}
       
    }




}
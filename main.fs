module Assignment

// Problem 1
let rec prod (lst:int list) =
    // write your solution here
    if List.isEmpty lst
    then 1
    else List.head lst * prod (List.tail lst)
    

// Problem 2
let rec map f (lst:int list) =
    //if List.isEmpty lst
    //then []
    //else lost:: f List.head lst::f map (List.tail lst)

// Problem 3
let rec odd (lst:int list) =
    // write your solution here
   // let lost:int list []
   // if List.isEmpty lst
    //then lost
    //else 
    //  if (List.head (lst) % 2 = 1)
    //  then  :: f odd (List.tail lst)
    lst

// Problem 4
let rec filter f lst =
    // write your solution here
    List.filter (f) lst

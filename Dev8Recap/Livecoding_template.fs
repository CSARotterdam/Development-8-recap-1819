module Livecoding_template

open Validation

let rec mapList (func : 'a -> 'b) (l : List<'a>) : List<'b> =
    //TODO, applies func to all elements in list l, in order, and returns a transformed list<'b>

let test1 = ValidateMapList mapList


let rec append (list1 : List<'a>) (list2:List<'a>) : List<'a> =
    //TODO, appends list 2 at the end of list1

let test2 = ValidateAppend append


let rec last (l : List<'a>) : Option<'a> =
    //TODO, gets the last element of list l, or None if the list l is empty

let test3 = ValidateLast last


let rec zip (list1 : List<'a>) (list2 : List<'b>) : Option<List<'a*'b>> =
    //TOTO, takes two lists, returns a list of tuples 'a*'b elementwise,
    //returns None is lists arent same size

let test4 = ValidateZip zip
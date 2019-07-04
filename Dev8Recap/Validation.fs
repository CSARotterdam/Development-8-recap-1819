module Validation

open System

let Assert istrue (truemessage : string) (falsemessage : string) = 
    if istrue
    then truemessage
    else falsemessage

let ValidateMapList (maplistfunc : ('a->'b) -> List<'a> -> List<'b>) : string =
    let nums = [1;2;3;4;5]
    let numsstring = ["1";"2";"3";"4";"5"]
    let tostr num = (string)num
    Assert (maplistfunc tostr nums = numsstring) "mapList works correctly" "mapList is not working"

let ValidateAppend (appendfunc : List<'a> -> List<'a> -> List<'a>) : string =
    let list1 = [1;2;3;4;5]
    let list2 = [6;7;8;9;10]
    let shouldbe = [1;2;3;4;5;6;7;8;9;10]
    Assert (appendfunc list1 list2 = shouldbe) "append works correctly" "append is not working"

let ValidateLast (lastFunc : List<'a> -> Option<'a>) : string =
    let noneworks = lastFunc [] = None
    let normalworks = lastFunc [1;2;3;4;5] = Some 5
    Assert (noneworks && normalworks) "append works correctly" "append is not working"

let ValidateZip (zipFunc : List<'a> -> List<'b> -> Option<List<'a*'b>>) : string =
    let twoempty = zipFunc [] [] = Some []
    let list1 = [1;2;3;4;5]
    let list2 = [6;7;8;9;10]
    let list3 = [11;12]
    let even = zipFunc list1 list2 = Some [1,6;2,7;3,8;4,9;5,10]
    let uneven = zipFunc list1 list3 = None
    Assert (twoempty && even && uneven) "zip works correctly" "zip is not working"
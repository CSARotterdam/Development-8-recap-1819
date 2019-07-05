module Oplossingen_livecoding
open Validation

let rec mapList (func : 'a -> 'b) (l : List<'a>) : List<'b> =
    match l with
    | [] -> []
    | head :: tail -> func head :: (mapList func tail)

let test1 = ValidateMapList mapList


let rec append (list1 : List<'a>) (list2:List<'a>) : List<'a> =
    match list1 with
    | head :: tail -> head :: (append tail list2)
    | [] ->
        match list2 with
        | head :: tail -> head :: (append [] tail)
        | [] -> []

let rec append_korter (list1 : List<'a>) (list2 : List<'a>) =
    match list1 with
    | [] -> list2
    | head :: tail -> head :: append tail list2
    
let test2 = ValidateAppend append + "\nKorte versie: " + ValidateAppend append_korter


let rec last (l : List<'a>) : Option<'a> =
    match l with
    | [] -> None
    | head :: tail -> 
        match tail with
        | [] -> Some head
        | _ -> last tail

let test3 = ValidateLast last


let rec zip (list1 : List<'a>) (list2 : List<'b>) : Option<List<'a*'b>> =
    match (list1, list2) with
    | ([],[]) -> Some []
    | (head1::tail1,head2::tail2) ->
        let tailresult = zip tail1 tail2
        match tailresult with
        | Some goedelijst -> (head1,head2) :: goedelijst |> Some
        | None -> None
    | (_,_) -> None

let test4 = ValidateZip zip
module fsharpsyntax

open System

let functie argument1 argument2 = argument1 + argument2

let functie_met_types (argument1 : int) (argument2 : int) = argument1 + argument2

let functie_met_return (argument1 : int) (argument2 : int) : int = argument1 + argument2

let infinityandbeyond =
    fun (x :int) -> x * 2

let functie_die_functie_accepteerd (functie_van_int_naar_string : int -> string) (cijfer : int) : string =
    functie_van_int_naar_string cijfer

let rec recursive_functie (nummer : int) (keer : int) = //recursieve keersom
    if keer > 0 then
        nummer + (recursive_functie nummer (keer-1))
    else 0

let generics (generic_arg1 : 'a) (generic_arg2 : 'b) : 'a*'b = generic_arg1,generic_arg2

let waarde = 10

let waarde2 = "voorbeeld"

let tuple = "eerste waarde","tweede waarde"

let tuple2 = "kan ook verschilende types zijn", 420

let voorbeeld_fst (argument : string * int) : string = fst argument
let voorbeeld_snd (argument : string * int) : int = snd argument

let eerste_deel,tweede_deel = tuple2

let option = Some "er is een waarde"
let option_leeg = None

type eenvoorbeeldtype =
    | Eenmogelijkheid
    | Nogeenmogelijkheid
    | MogelijkheidMetwaarde of int
    | NogEentje of int
    | VanTuple of int*string

type Option<'a>=
    | Some of 'a
    | None

type typemetgenerics<'generic, 'anderegeneric>=
    | Iets of 'generic
    | Anders of Option<'anderegeneric>

type voorbeeldrecord = {
    voornaam : string;
    achternaam : string
}

let voorbeeldpersoon = {voornaam = "liesje"; achternaam = "janssen"}

type voorbeeldrecord2<'a> = {
    eenveld : string;
    genericveld : 'a
}

let voorbeeldgeneric = {eenveld="iets"; genericveld=5682}
let voorbeeldgeneric2 = {eenveld="iets"; genericveld="hoi"}
let voorbeeldgeneric3 = {eenveld="iets"; genericveld=[45;678;432]}

let x = {voorbeeldgeneric with eenveld="nieuw"} //copy voorbeeldgeneric, maar verander eenveld

type voorbeeldtype =
    | Mogelijkheid1 //zonder waarde
    | Mogelijkheid2 of int //met een waarde int
    | Mogelijkheid3 of string*int //met tuple waarde

let matchvoorbeeld (arg1 : voorbeeldtype) : Option<string*int> =
    match arg1 with
    | Mogelijkheid1 -> None
    | Mogelijkheid2 waarde -> None
    | Mogelijkheid3 (stringwaarde, intwaarde)-> Some (stringwaarde, intwaarde)

let matchmetwaardes (arg1 : int * int) : String =
    match arg1 with
    | (42, 420) -> "42 en 420"
    | (69, 69) -> "6969 :P"
    | (69, _) -> "alles waar de eerste 69 is"
    | (_, 47) -> "alles waar de tweede 47 is"
    | (_, _) -> "Alles wat over is"

let voorbeeldlijst = ["element1" ; "element 2" ; "element3"] //een lijst heeft 1 type, List<string>

let matcheenlijst (lijst1 : List<'a>) =
    match lijst1 with
    | head :: tail -> "Lijst1 heeft >ten minste< 1 waarde, head. Tail is de rest van de lijst (kan leeg zijn)"
    | [] -> "Er is geen waarde in lijst1"

let voegitemaanlijsttoe = "een item" :: ["een bestaande lijst" ; "nog meer items in de lijst" ; "etc"]

let functiemet2argumenten arg1 arg2 = arg1 + arg2

let curriedfunctie arg2 = functiemet2argumenten 22 arg2

//is hetzelfde andere vorm
let curriedfunctie2 = functiemet2argumenten 22

let dubbel (arg : int) : int = arg * 2
let plus3 (arg : int) : int = arg + 3

let zelfde_als_onder = dubbel (5 + 7 * 9)
let pipevoorbeeld = 5 + 7 * 9 |> dubbel
let pipevoorbeeld2 = dubbel <| plus3 1 //= 8
let pipevoorbeeld3 = plus3 1 |> dubbel //= 8

let keer10 arg = arg*10
let plus2 arg = arg+2

let plus2_dan_keer10 = plus2 >> keer10
let keer10_dan_plus2 = keer10 >> plus2
let keer10_dan_plus2_zelfde arg = keer10 >> plus2 <| arg

let voorbeeeld nummer =
    nummer |>
    keer10 |>
    plus2




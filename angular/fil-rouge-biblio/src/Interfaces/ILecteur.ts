import { IEmprunt } from "./IEmprunt";

export interface ILecteur {
    Id: number,
    Nom: string,
    Prenom: string,
    Email: string,
    Telephone: string,
    Adresse: string,
    Cotisation: boolean,
    ListEmprunts: IEmprunt[]
}
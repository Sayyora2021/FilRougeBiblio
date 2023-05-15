import { ILivre } from "./ILivre";

export interface IAuteur {
    Id: number,
    Nom: string,
    Prenom: string,
    Livres: ILivre[]
}
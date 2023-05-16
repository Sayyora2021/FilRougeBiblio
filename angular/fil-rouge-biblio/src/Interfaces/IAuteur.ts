import { ILivre } from "./ILivre";

export interface IAuteur {
    id: number,
    nom: string,
    prenom: string,
    livres: ILivre[]
}
import { ILivre } from "./ILivre";

export interface IExemplaire {
    Id: number,
    Livre: ILivre,
    NumeroInventaire: string,
    MiseEnService: Date
}
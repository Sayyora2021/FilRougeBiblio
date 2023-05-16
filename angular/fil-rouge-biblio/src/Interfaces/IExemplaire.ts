import { ILivre } from "./ILivre";

export interface IExemplaire {
    id: number,
    livre: ILivre,
    numeroInventaire: string,
    miseEnService: Date
}
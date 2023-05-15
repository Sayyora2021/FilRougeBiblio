import { ILivre } from "./ILivre";

export interface IMotClef {
    Id: number,
    Tag: string,
    Livres: ILivre[]
}
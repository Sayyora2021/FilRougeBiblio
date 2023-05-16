import { ILivre } from "./ILivre";

export interface IMotClef {
    id: number,
    tag: string,
    livres: ILivre[]
}
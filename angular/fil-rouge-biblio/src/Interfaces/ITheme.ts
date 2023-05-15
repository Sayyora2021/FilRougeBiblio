import { ILivre } from "./ILivre";

export interface ITheme {
    Id: number,
    Nom: string,
    Description: string,
    Livres: ILivre[],
}
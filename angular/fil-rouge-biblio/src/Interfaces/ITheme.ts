import { ILivre } from "./ILivre";

export interface ITheme {
    id: number,
    nom: string,
    description: string,
    livres: ILivre[],
}
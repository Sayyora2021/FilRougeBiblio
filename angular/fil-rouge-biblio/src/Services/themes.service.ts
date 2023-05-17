import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { ITheme } from 'src/Interfaces/ITheme';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ThemesService {

  constructor(private http:HttpClient) { }

  listAll() : Observable<ITheme[]>{

    return this.http.get<ITheme[]>('https://localhost:7120/api/Themes').pipe(
    map((data: ITheme[]) => {
      return data;
    })
  );
  }
  
  delete(themeId:number){
    this.http.delete<ITheme>('https://localhost:7120/api/Themes/Delete/'+themeId).subscribe(d => console.log(d));
  }

  create(theme:ITheme){
    this.http.post<ITheme>('https://localhost:7120/api/Themes/Create',theme).subscribe(d => console.log(d));
  }

  update(theme:ITheme) {
    let apiTheme = { Nom: theme.nom, Description: theme.description }
    this.http.put<ITheme>('https://localhost:7120/api/Themes/Edit/'+ theme.id, apiTheme).subscribe(d => console.log(d))
  }

  details(id:number) : Observable<ITheme>{
    return this.http.get<ITheme>('https://localhost:7120/api/Themes/Details/' + id)
  }
}

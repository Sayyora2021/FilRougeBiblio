import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { ITheme } from 'src/Interfaces/ITheme';
import { HttpClient } from '@angular/common/http';
import { apiconfig } from 'apiconfig';


@Injectable({
  providedIn: 'root'
})
export class ThemesService {

  path = apiconfig.adress + '/Themes';

  constructor(private http:HttpClient) { }

  listAll() : Observable<ITheme[]>{

    return this.http.get<ITheme[]>(this.path).pipe(
    map((data: ITheme[]) => {
      return data;
    })
  );
  }
  
  delete(themeId:number){
    this.http.delete<ITheme>(this.path + '/Delete/' + themeId).subscribe(d => console.log(d));
  }

  create(theme:ITheme){
    this.http.post<ITheme>(this.path + '/Create',theme).subscribe(d => console.log(d));
  }

  update(theme:ITheme) {
    let apiTheme = { Nom: theme.nom, Description: theme.description }
    this.http.put<ITheme>(this.path +'/Edit/'+ theme.id, apiTheme).subscribe(d => console.log(d))
  }

  details(id:number) : Observable<ITheme>{
    return this.http.get<ITheme>(this.path + '/Details/' + id)
  }
}

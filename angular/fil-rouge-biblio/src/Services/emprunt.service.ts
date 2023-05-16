import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { IEmprunt } from 'src/Interfaces/IEmprunt';

@Injectable({
  providedIn: 'root'
})
export class EmpruntService {

  path = 'https://localhost:7120/api/Emprunts';


  constructor(private http: HttpClient) { 
    
  }

  create(lecteur:IEmprunt){
    this.http.post<IEmprunt>(this.path + '/Create',lecteur).subscribe();
  }


  delete(id:number){
    this.http.delete<IEmprunt>(this.path + '/Delete/'+id).subscribe();
  }

  listAll() : Observable<IEmprunt[]>{

    return this.http.get<IEmprunt[]>(this.path).pipe(
    map((data: IEmprunt[]) => {
      return data;
    })
  );

  }

}

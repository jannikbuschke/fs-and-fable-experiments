import { Record } from "../src/fable_modules/fable-library-ts/Types.js";
import { int32 } from "../src/fable_modules/fable-library-ts/Int32.js";
import { lambda_type, list_type, unit_type, record_type, class_type, string_type, int32_type, TypeInfo } from "../src/fable_modules/fable-library-ts/Reflection.js";

export class Album extends Record {
    readonly id: int32;
    readonly title: string;
    readonly genre: string;
    readonly released: Date;
    constructor(id: int32, title: string, genre: string, released: Date) {
        super();
        this.id = (id | 0);
        this.title = title;
        this.genre = genre;
        this.released = released;
    }
}

export function Album$reflection(): TypeInfo {
    return record_type("Shared.Album", [], Album, () => [["id", int32_type], ["title", string_type], ["genre", string_type], ["released", class_type("System.DateTime")]]);
}

export class NewAlbumInfo extends Record {
    readonly title: string;
    readonly genre: string;
    readonly released: Date;
    constructor(title: string, genre: string, released: Date) {
        super();
        this.title = title;
        this.genre = genre;
        this.released = released;
    }
}

export function NewAlbumInfo$reflection(): TypeInfo {
    return record_type("Shared.NewAlbumInfo", [], NewAlbumInfo, () => [["title", string_type], ["genre", string_type], ["released", class_type("System.DateTime")]]);
}

export class IMusicStore extends Record {
    readonly popularAlbums: (() => any);
    constructor(popularAlbums: (() => any)) {
        super();
        this.popularAlbums = popularAlbums;
    }
}

export function IMusicStore$reflection(): TypeInfo {
    return record_type("Shared.IMusicStore", [], IMusicStore, () => [["popularAlbums", lambda_type(unit_type, class_type("Microsoft.FSharp.Control.FSharpAsync`1", [list_type(Album$reflection())]))]]);
}

//# sourceMappingURL=Library.fs.ts.map

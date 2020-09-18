Role = function () {

    this.categoryInfo = {
        "name": "role_category",
        "type": "list"
    };
    this.categoryShape = {
        "name": "shape_category",
        "type": "list"
    };
    this.list = {
        "name": "role",
        "type": "list"
    }
    //debug
  //  alert(JSON.stringify(json).toString());
}

Role.prototype.getCategoryInfo = function () {
    return this.categoryInfo;
}
Role.prototype.getInfo = function (name,type) {
    return {
        "name": name || "role",
        "type": type || "add",
        "info": {
            "priority_id": $("#role_priority").find("option:selected").val(),
            "role_catgory": {
                "id": $("#role_category").find("option:selected").val(),
                "name": $("#role_category").find("option:selected").text()
            },

            "incident_info": {
                "prioity_id": $("#incident_prioity").find("option:selected").val(),
                "desc": $("#incident_desc").val()
            },


            "desc": $("#role_desc").val(),
            "insert_time": "",
            "update_time": "",
            "parent_id": $("#role_parent_id").val(),
            "parent_name": $("#role_parent_name").val(),
            "id": $("#role_id").val(),
            "name": $("#role_name").val()
        }
    }
}
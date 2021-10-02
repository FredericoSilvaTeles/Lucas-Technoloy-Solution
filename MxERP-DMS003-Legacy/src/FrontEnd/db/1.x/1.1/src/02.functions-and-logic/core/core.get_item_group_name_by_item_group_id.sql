DROP FUNCTION IF EXISTS core.get_item_group_name_by_item_group_id(integer);

CREATE FUNCTION core.get_item_group_name_by_item_group_id(integer)
RETURNS text
AS
$$
BEGIN
        RETURN item_group_name
        FROM core.item_groups
        WHERE item_group_id=$1;
END
$$
LANGUAGE plpgsql;

